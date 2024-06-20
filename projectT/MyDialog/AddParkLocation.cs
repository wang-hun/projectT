using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class AddParkLocation : UIEditForm
    {
        public AddParkLocation()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ischeck = false;
            PosX = 0;
            PosY = 0;
        }
        private PointLatLng mouseDownPos;
        GMapOverlay markers = new GMapOverlay("lay");
        public static bool ischeck = false;
        public static double PosX = 0;
        public static double PosY = 0;
        private void gMapControl1_Load(object sender, EventArgs e)
        {
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
            this.gMapControl1.Overlays.Add(markers);//增加标记图层
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!ischeck)
            {
                //当前鼠标按下时的位置信息赋值给mouseDownPos
                mouseDownPos = this.gMapControl1.FromLocalToLatLng(e.X, e.Y);
                //在鼠标点击处创建一个标记点
                GMapMarker marker = new GMarkerGoogle(mouseDownPos, GMarkerGoogleType.blue_pushpin);
                //将该标记添加到图层中
                markers.Markers.Add(marker);
                ischeck = true;
            }
            else
            {
                //当前鼠标按下时的位置信息赋值给mouseDownPos
                mouseDownPos = this.gMapControl1.FromLocalToLatLng(e.X, e.Y);
                //在鼠标点击处创建一个标记点
                GMapMarker marker = new GMarkerGoogle(mouseDownPos, GMarkerGoogleType.blue_pushpin);
                //将该标记添加到图层中
                markers.Markers.Clear();
                markers.Markers.Add(marker);
                ischeck = true;
                
            }
            PosX = markers.Markers[0].Position.Lat;
            PosY = markers.Markers[0].Position.Lng;
            uiDigitalLabel1.Value = PosX;
            uiDigitalLabel2.Value = PosY;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            uiDigitalLabel1.Value = 0;
            uiDigitalLabel2.Value = 0;
            ischeck = false;
            markers.Markers.Clear();
        }
    }
}

