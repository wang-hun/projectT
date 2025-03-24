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
        private string _parkName;
        public string ParkName
        {
            get => _parkName;
            set
            {
                _parkName = value;
                OnPropertyChanged(nameof(ParkName));
                var park = Parks.Where(pk=>pk.Name== value).First()??new Local();
                if (!park.Name.IsNullOrEmpty()) 
                {
                Local= park.Name+"="+park.PosX+"+"+park.PosY;
                }
            }
        }
        public string CarNumber { get; set; }
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
    }


    public class Local
    {
        public string Name { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }


    }
}
