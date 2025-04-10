using AduSkin.Controls.Metro;
using projectW.tab;
using ProjectW;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace projectW
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        private UserControl[] tabs ={
            new UserControl1(),
            new UserControl2(),
            new UserControl3(),
            new UserControl4()
        };
        public ObservableCollection<string> StepItems { get; set; }
        public string Local { get; set; }

        public List<string> CarNumbers { get; set; }
        public List<Local> Parks { get; set; }
        public List<string> ParkNames { get; set; }

        public DateTime StartTime
        {
            get => _startTime;
            set
            {
                _startTime = value;
                OnPropertyChanged(nameof(StartTime));
            }
        }
        private DateTime _startTime;
        private DateTime _endTime;
        public DateTime EndTime
        {
            get => _endTime;
            set
            {
                _endTime = value;
                OnPropertyChanged(nameof(EndTime));
            }
        }
        private string _parkName;
        public string ParkName
        {
            get => _parkName;
            set
            {
                _parkName = value;
                OnPropertyChanged(nameof(ParkName));
                if (!value.IsNullOrEmpty())
                {
                    var park = Parks.Where(pk => pk.Name == value).First() ?? new Local();
                    if (!park.Name.IsNullOrEmpty())
                    {
                        Local = park.Name + "=" + park.PosX.ToString("F10") + "+" + park.PosY.ToString("F10");
                    }
                }
            }
        }
        private string _carNumber;
        public string CarNumber
        {
            get => _carNumber;
            set
            {
                _carNumber = value;
                OnPropertyChanged(nameof(CarNumber));
            }
        }
        private int _stepIndex;
        public int StepIndex
        {
            get => _stepIndex;
            set
            {
                if (_stepIndex != value)
                {

                    bool inputIsUull = false;
                    if (_stepIndex < value)
                    {
                        switch (StepIndex)
                        {
                            case 0:
                                if (CarNumber.IsNullOrEmpty())
                                {
                                    inputIsUull = true;
                                    AduMessageBox.Show("请选择需要停放的车辆!", "提示", MessageBoxButton.OK, MessageBoxImage.Warning);
                                }
                                break;
                            case 1:
                                if (ParkName.IsNullOrEmpty())
                                {
                                    inputIsUull = true;
                                    AduMessageBox.Show("请选择需要停放的位置!", "提示", MessageBoxButton.OK, MessageBoxImage.Warning);
                                }
                                break;
                            case 2:
                                var tab2 = (UserControl3)tabs[2];
                                StartTime = tab2.timer1.SelectedTime;
                                EndTime = tab2.timer2.SelectedTime;
                                if (EndTime <= StartTime)
                                {
                                    inputIsUull = true;
                                    AduMessageBox.Show("结束时间应当晚于开始时间!", "提示", MessageBoxButton.OK, MessageBoxImage.Warning);

                                }
                                break;
                        }
                    }
                    if (!inputIsUull)
                    {
                        _stepIndex = value;
                        OnPropertyChanged(nameof(StepIndex));
                        UpdateButtonStates(); // 更新按钮状态

                    }
                }
            }
        }
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = this;
            StepItems = new ObservableCollection<string>();
            StepItems.Add("第一步");
            StepItems.Add("第二步");
            StepItems.Add("第三步");
            StepItems.Add("第四步");
            foreach (var tab in tabs)
            {
                tab.DataContext = this;
            }
            IsPreviousEnabled = false;
            IsNextEnabled = true;
            tab.Content = tabs[StepIndex];
            LoadBlcokChain();
            LoadSQL();
            //订阅确定按钮事件。
            var userControl4 = tabs[3] as UserControl4;
            userControl4.CustomButtonClick += IsOKButtonClick;
        }
        private void LoadSQL()
        {
            LoadCarNumber();
            LoadLocal();
        }
        private void LoadBlcokChain()
        {
            BlockchainManager.startBlockChain("/BlockChain");

        }
        private void LoadCarNumber()
        {
            CarNumbers = new List<string>();
            var dr = SQLClass.ExecuteReader("select CarNumber from cars");
            while (dr.Read())
            {
                CarNumbers.Add(dr[0].ToString());
            }
        }
        private void LoadLocal()
        {
            Parks = new List<Local>();
            ParkNames = new List<string>();
            var ds = SQLClass.GetDataSet("select Location,posX,posY from park");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    var name = row["location"].ToString();
                    ParkNames.Add(name);
                    Parks.Add(new Local
                    {
                        Name = name,
                        PosX = Convert.ToDouble(row["posX"]),
                        PosY = Convert.ToDouble(row["posY"])
                    });
                }
            }
        }
        public bool IsPreviousEnabled { get; set; }
        public bool IsNextEnabled { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateButtonStates()
        {
            // 根据StepIndex更新按钮状态
            IsPreviousEnabled = StepIndex > 0;
            IsNextEnabled = StepIndex < 3;

            OnPropertyChanged(nameof(IsPreviousEnabled));
            OnPropertyChanged(nameof(IsNextEnabled));

            tab.Content = tabs[StepIndex];
        }

        public void PreButton_Click(object sender, RoutedEventArgs e)
        {
            if (StepIndex > 0)
            {
                StepIndex--;
                stepBar.Progress = StepIndex;
            }
        }
        public void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (StepIndex < 3)
            {
                StepIndex++;
                stepBar.Progress = StepIndex;
            }
        }

        private void IsOKButtonClick(object sender, RoutedEventArgs e)
        {
            var hash=BlockchainManager.creatBlock(Local);
            SQLClass.ExecuteSql(
                "INSERT INTO `carpark` ( `LicNumber`, `StartParkTime`, `EndParkTime`, `ParkLocal`) " +
                "VALUES ( '"+ CarNumber + "', '"+StartTime+"', '"+EndTime+"', '"+hash+"')");
            AduMessageBox.Show("停车事件已记录！", "提示");
            
            renew();
        }
        //重置
        private void renew() 
        {
            // 重置步骤索引到初始状态
            StepIndex = 0;
            stepBar.Progress = 0;
            tab.Content = tabs[0];


            // 清空用户选择
            CarNumber = string.Empty;
            ParkName = string.Empty;
            Local = string.Empty;

            // 重置时间控件到默认值（保持与构造函数相同的逻辑）
            StartTime = DateTime.Now.Date.AddHours(8);  // 假设原始默认开始时间
            EndTime = DateTime.Now.Date.AddHours(20);   // 假设原始默认结束时间

            // 强制刷新所有绑定（保持原有通知机制）
            OnPropertyChanged(nameof(CarNumber));
            OnPropertyChanged(nameof(ParkName));
            OnPropertyChanged(nameof(Local));
            OnPropertyChanged(nameof(StartTime));
            OnPropertyChanged(nameof(EndTime));
            var tabs0=tabs[0] as UserControl1;
            tabs0.renew();
            var tabs1 = tabs[1] as UserControl2;
            tabs1.renew();
            var tabs2 = tabs[2] as UserControl3;
            tabs2.timer1.SelectedTime=DateTime.Now;
            tabs2.timer2.SelectedTime=DateTime.Now;
        }
    }


    public class Local
    {
        public string Name { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }


    }
}
