using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MySql.Data.MySqlClient;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectT
{
    public partial class InFormFindPark : UIPage
    {
        public InFormFindPark()
        {
            InitializeComponent();
        }
        //private PointLatLng mouseDownPos;
        static List<Park> parks = new List<Park>();
        GMapOverlay markers = new GMapOverlay("lay");
       public void Renew() {
            MySqlDataReader ds = SQLClass.ExecuteReader("SELECT location,PosX,PosY FROM park");

            parks.Clear();
            markers.Markers.Clear();
            gMapControl1.Overlays.Clear();
            while (ds.Read()) // 逐行读取数据
            {
                Park park = new Park
                {
                    Location = ds.GetString(0), // "location"列的值
                    PosX = ds.GetDouble(1),     // "PosX"列的值
                    PosY = ds.GetDouble(2)      // "PosY"列的值
                };
                parks.Add(park); // 将实例化的Park对象添加到列表中
            }


            foreach (Park park in parks)
            {
                // 创建标记，这里以GMarkerGoogle为例，使用默认的红色图标
                GMarkerGoogle marker = new GMarkerGoogle(
                    new PointLatLng(park.PosX, park.PosY), // 注意坐标顺序，PosX对应经度，PosY对应纬度
                    GMarkerGoogleType.red);

                // 可以为标记添加标签或自定义点击事件等
                marker.ToolTipText = park.Location; // 显示位置名称作为提示信息
               // marker.MouseClick += Marker_MouseClick; // 注册鼠标点击事件处理方法

                // 将标记添加到覆盖层
                markers.Markers.Add(marker);
            }

            // 别忘了关闭数据读取器和可能的数据库连接
            ds.Close();


            this.gMapControl1.Overlays.Add(markers);//增加标记图层

        }
        private void InFormFindPark_Load(object sender, EventArgs e)
        {
            #region 窗体初始化
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);

            Image originalImage = uiImageButton1.Image;
            uiImageButton1.ImagePress = PublicClass.AdjustBrightness(originalImage, -0.2f); // 调整亮度为更暗
            uiImageButton1.ImageHover = PublicClass.AdjustBrightness(originalImage, 0.4f); // 调整亮度为更亮

            string mapPath = Application.StartupPath + "\\MapOfTheCity.gmdb";
            GMap.NET.GMaps.Instance.ImportFromGMDB(mapPath);
            // gMapControl1.Manager.Mode = AccessMode.CacheOnly;//  ServerOnly,ServerAndCache设置从服务器和缓存中获取地图数据
            gMapControl1.MapProvider = GMapProviders.OpenCycleTransportMap;//GMapProviders.GoogleChinaMap;   //谷歌中国地图         
            gMapControl1.MinZoom = 3;      //最小比例
            gMapControl1.MaxZoom = 18;     //最大比例
            gMapControl1.Zoom = 10;        //当前比例
            //this.gMapControl1.ShowCenter = false;//不显示中心十字标记
            this.gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;//左键拖拽地图
            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionAndCenter;//鼠标缩放模式
            gMapControl1.Position = new PointLatLng(32.043336, 120.808717);//地图中心坐标
           
            Renew();
            #endregion

        }
        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (uiTextBox1.Text == "")
            {
                uiTextBox1.Text = "请输入位置说明";
                uiTextBox1.ForeColor = Color.Gray;
            }
            else
            {
                uiTextBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (uiTextBox1.Text == "请输入位置说明")
            {
                uiTextBox1.Text = "";
                uiTextBox1.ForeColor = Color.Black;
            }

        }

    }
    public class Park
    {
        public string Location { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
    }
}
