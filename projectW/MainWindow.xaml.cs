using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AduSkin.Controls.Metro;
using projectW.tab;
using ProjectW;


namespace projectW
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        private UserControl[] tabs={
            new UserControl1(),
            new UserControl2(),
            new UserControl3(),
            new UserControl4()
        };
        public ObservableCollection<string> StepItems { get; set; }

        public List<string> CarNumbers {  get; set; } 
        private int _stepIndex;
        public int StepIndex
        {
            get => _stepIndex;
            set
            {
                if (_stepIndex != value)
                {
                    _stepIndex = value;
                    OnPropertyChanged(nameof(StepIndex));
                    UpdateButtonStates(); // 更新按钮状态
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
            if (StepIndex > 0) { 
                StepIndex--;
                stepBar.Progress = StepIndex;
            }
        }
        public void nextButton_Click(object sender, RoutedEventArgs e)
        {
            if (StepIndex < 3) {
                StepIndex++;
                stepBar.Progress = StepIndex;
            }
        }
    }
}
