using AduSkin.Controls.Metro;
using Google.Protobuf.WellKnownTypes;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
using projectT;
using ProjectT;
using projectW.tab;
using System;
using System.Collections.Generic;
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
        private ObservableCollection<string> _carnumbersOut;
        public ObservableCollection<string> CarnumbersOut
        {
            get => _carnumbersOut;
            set
            {
                _carnumbersOut = value;
                OnPropertyChanged(nameof(CarnumbersOut));
            }
        }
        private string _carNumberIn;
        public string CarNumberIn
        {
            get => _carNumberIn;
            set
            {
                _carNumberIn = value;
                OnPropertyChanged(nameof(CarNumberIn));
            }
        }
        private string _carNumberOut;
        public string CarNumberOut
        {
            get => _carNumberOut;
            set
            {
                _carNumberOut = value;
                OnPropertyChanged(nameof(CarNumberOut));
            }
        }
        private ObservableCollection<string> _parksIn;
        public ObservableCollection<string> ParksIn
        {
            get => _parksIn;
            set
            {
                _parksIn = value;
                OnPropertyChanged(nameof(ParksIn));
            }
        }
        private string _parkIn;
        public string ParkIn
        {
            get => _parkIn;
            set
            {
                _parkIn = value;
                OnPropertyChanged(nameof(ParkIn));
            }
        }
        private string _parkOut;
        public string ParkOut
        {
            get => _parkOut;
            set
            {
                _parkOut = value;
                OnPropertyChanged(nameof(ParkOut));
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
            (tabs[0] as InTab).father = this;
            (tabs[1] as OutTab).father = this;
            tab.Content = this.tabs[0];
            tabs[0].DataContext = this;
            tabs[1].DataContext = this;
            _nowParks = new ObservableCollection<CarPark>();
            _parks = new ObservableCollection<Park>();
            _cars = new ObservableCollection<Car>();
            CarnumbersIn = new ObservableCollection<string>();
            CarnumbersOut = new ObservableCollection<string>();
            ParksIn = new ObservableCollection<string>();
            BlockchainManager.startBlockChain("/BlockChain");
            renew();
        }
        private void Window_Closed(object sender, EventArgs e)
        {

        }
        private void InButtonClick(object sender, RoutedEventArgs e)
        {
            renew();
            tab.Content = this.tabs[0];
        }
        private void OutButtonClick(object sender, RoutedEventArgs e)
        {
            renew();
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
            loadOutTab();
        }
        private void loadInTab()
        {

            CarnumbersIn.Clear();
            ParksIn.Clear();
            foreach (var c in Cars)
            {
                var number = c.carNumber;
                if (
                    !NowParks.Where(p => !p.LicNumber.IsNullOrEmpty() && p.LicNumber.Equals(number)).Any()//不包含
                   )
                {
                    CarnumbersIn.Add(number);
                }
            }
            foreach (var p in Parks.Where(p => p.MaxPost > p.NowPost).Where(p => p.Opening).Select(p => p.Location))
            {

                ParksIn.Add(p);
            }
            CarNumberIn = null;
            ParkIn = null;
        }
        private void loadOutTab()
        {

            CarnumbersOut.Clear();

            foreach (var p in NowParks)
            {
                CarnumbersOut.Add(p.LicNumber);
            }
            CarNumberOut = null;
            ParkOut = null;
        }
        public bool SaveInPark()
        {
            if (!ParkIn.IsNullOrEmpty() && !CarNumberIn.IsNullOrEmpty())
            {
                var park = Parks.Where(p => p.Location == ParkIn).First();
                var parkDate = park.Location + "=" + park.PosX.ToString("F10") + "+" + park.PosY.ToString("F10");
                SQLClass.ExecuteSql("UPDATE `park` SET `nowParking` = " + (park.NowPost + 1) +
                                      " WHERE `location` ='" + park.Location + "'");
                var hash = BlockchainManager.creatBlock(parkDate);

                SQLClass.ExecuteSql("INSERT INTO nowpark(carNumber, parkStartTime, local)VALUES(" +
                    "\"" + CarNumberIn + "\",\"" + DateTime.Now + "\",\"" + hash + "\"" +
                    ")");
                AduMessageBox.Show("停车事件已记录！", "提示");
                return true;
            }
            else
            {
                AduMessageBox.Show("选项不能为空！", "提示");
                return false;

            }

        }

        /// <summary>
        /// 开出模拟中，选择车辆后，显示在哪个停车场
        /// </summary>
        public void showThePark()
        {
            if (!CarNumberOut.IsNullOrEmpty())
            {
                var parkDate = NowParks.Where(p => p.LicNumber.Equals(CarNumberOut)).First();
                if (parkDate != null)
                {
                    var block = BlockchainManager._blockChain.Where(b => b.Hash.Equals(parkDate.ParkLocal)).First();
                    if (block != null)
                    {
                        ParkOut = block.local.Split('=')[0];
                    }
                    //else
                    //区块链损坏，我也在想应该怎么处理
                }
            }
        }

        public bool SaveOutPark()
        {
            if (!CarNumberOut.IsNullOrEmpty())
            {
                var park = Parks.Where(p => p.Location == ParkOut).First();
                var parkDate = park.Location + "=" + park.PosX.ToString("F10") + "+" + park.PosY.ToString("F10");
                var nowParkDate = NowParks.Where(p => p.LicNumber.Equals(CarNumberOut)).First();
                SQLClass.ExecuteSql("UPDATE `park` SET `nowParking` = " + (park.NowPost + 1) +
                                      " WHERE `location` ='" + park.Location + "'");
                var hash = BlockchainManager.creatBlock(parkDate);
                SQLClass.ExecuteSql(
              "INSERT INTO `carpark` ( `LicNumber`, `StartParkTime`, `EndParkTime`, `ParkLocal`) " +
              "VALUES ( '" + CarNumberOut + "', '" + nowParkDate.StartParkTime + "', '" + DateTime.Now + "', '" + hash + "')");
                SQLClass.ExecuteSql("DELETE FROM nowpark WHERE carNumber = \"" + CarNumberOut + "\"");
                AduMessageBox.Show("停车事件已记录！", "提示");
                return true;
            }
            else
            {
                AduMessageBox.Show("选项不能为空！", "提示");
                return false;

            }

        }
    }
}
