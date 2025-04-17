using AduSkin.Controls.Metro;
using projectT;
using ProjectT;
using projectW.tab;
using ProjectW;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace projectW
{
    /// <summary>
    /// InOutWindow.xaml 的交互逻辑
    /// </summary>
    public partial class InOutWindow : MetroWindow, INotifyPropertyChanged
    {
        private ObservableCollection<CarPark> _nowParks;
        public ObservableCollection<CarPark> NowParks
        {
            get => _nowParks;
            set
            {
                _nowParks = value;
                OnPropertyChanged(nameof(NowParks));
            }
        }
        private ObservableCollection<Park> _parks;
        public ObservableCollection<Park> Parks
        {
            get => _parks;
            set
            {
                _parks = value;
                OnPropertyChanged(nameof(Parks));
            }
        }
        private ObservableCollection<string> _carnumbersIn;
        public ObservableCollection<string> CarnumbersIn
        {
            get => _carnumbersIn;
            set
            {
                _carnumbersIn = value;
                OnPropertyChanged(nameof(CarnumbersIn));
            }
        }
        private ObservableCollection<string> _carNumberIn;
        public ObservableCollection<string> CarNumberIn
        {
            get => _carNumberIn;
            set
            {
                _carNumberIn = value;
                OnPropertyChanged(nameof(CarNumberIn));
            }
        }
        private ObservableCollection<Car> _cars;
        public ObservableCollection<Car> Cars
        {
            get => _cars;
            set
            {
                _cars = value;
                OnPropertyChanged(nameof(Cars));
            }
        }
        private UserControl[] tabs = {
        new InTab(),
        new OutTab()
        };

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public InOutWindow()
        {
            InitializeComponent();
            tab.Content = this.tabs[0];
            tabs[0].DataContext = this;
            tabs[1].DataContext = this;
            (tabs[0] as InTab).father = this;
            (tabs[1] as OutTab).father = this;
            _nowParks = new ObservableCollection<CarPark>();
            _parks = new ObservableCollection<Park>();
            _cars = new ObservableCollection<Car>();
            CarnumbersIn = new ObservableCollection<string>();
            renew();
        }
        private void Window_Closed(object sender, EventArgs e)
        {

        }
        private void InButtonClick(object sender, RoutedEventArgs e)
        {
            tab.Content = this.tabs[0];
        }
        private void OutButtonClick(object sender, RoutedEventArgs e)
        {
            tab.Content = this.tabs[1];
        }
        public void renew()
        {
            var cars = SQLClass.ExecuteReader("select * from cars");
            var parks = SQLClass.ExecuteReader("select * from park");
            var nowparks = SQLClass.ExecuteReader("select * from nowpark");
            Cars.Clear();
            Parks.Clear();
            NowParks.Clear();
            while (cars.Read())
            {
                // 逐行读取数据并创建对象
                var car = new Car
                {
                    // 通过列名或索引直接提取值
                    carNumber = cars.GetString("carNumber"),      // 使用列名
                };

                Cars.Add(car);

            }
            while (parks.Read())
            {
                var park = new Park
                {
                    NowPost = parks.GetInt32("nowParking"),
                    MaxPost = parks.GetInt32("maxParking"),
                    Location = parks.GetString("location"),
                    Opening = parks.GetBoolean("opening"),
                    PosX = parks.GetDouble("PosX"),
                    PosY = parks.GetDouble("PosY")


                };
                Parks.Add(park);
            }
            while (nowparks.Read())
            {
                var nowPark = new CarPark
                {
                    ParkLocal = nowparks.GetString("local"),
                    LicNumber = nowparks.GetString("carNumber"),
                    StartParkTime = nowparks.GetDateTime("parkStartTime"),
                };
                NowParks.Add(nowPark);
            }
            cars.Close();
            parks.Close();
            nowparks.Close();
            loadInTab();
        }
        private void loadInTab() 
        {
            
            CarnumbersIn.Clear();
            foreach (var c in Cars) 
            {
                var number = c.carNumber;
                if (
                    !NowParks.Where(p => !p.LicNumber.IsNullOrEmpty()&& p.LicNumber.Equals(number)).Any()//不包含
                   ) 
                {
                    CarnumbersIn.Add(number);
                }
            }
            CarNumberIn = null;
        }
    }
}
