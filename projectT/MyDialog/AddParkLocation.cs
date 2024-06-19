using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
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
                
            }
        public static GMapOverlay OverlayMarker;
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
            gMapControl1.Position = new PointLatLng(32.043336,120.808717);//地图中心坐标
        }
    }
    }

