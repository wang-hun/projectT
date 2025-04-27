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
    public partial class WhereMyCar : UIEditForm
    {
        private DateTime startTime { get; set; }
        private DateTime endTime { get; set; }
        private string carNmuber { get; set; }
        private string local { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }

        public WhereMyCar(string carNmuber, string locals, DateTime startTime, DateTime endTime = default)
        {
            InitializeComponent();
            this.carNmuber = carNmuber;
            this.startTime = startTime;
            this.endTime = endTime;
            var parts = locals.Split(new[] { '=', '+' });
            local = parts[0];
            PosX = double.Parse(parts[1]);
            PosY = double.Parse(parts[2]);
            uiLabel1.Text = this.carNmuber;
            uiLabel2.Text = this.local;
            uiLabel3.Text = this.startTime.ToString("yy年MM月dd日 HH:mm:ss");
            if (this.endTime != default)
                uiLabel4.Text = this.endTime.ToString("yy年MM月dd日 HH:mm:ss");
            else
            {
                uiLabel4.Text = "该车目前并未开出。";
                uiLabel4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff007f");
            }
        }



        private PointLatLng mouseDownPos;
        GMapOverlay markers = new GMapOverlay("lay");

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
            var pos = new PointLatLng(PosX, PosY); // 注意检查经纬度是否对应XY
            var marker = new GMarkerGoogle(pos, GMarkerGoogleType.red);
            marker.ToolTipText = local;
            marker.ToolTipMode = MarkerTooltipMode.Always;

            // 将标注添加到图层
            markers.Markers.Add(marker);
            gMapControl1.Position = pos; // 可选：将地图中心定位到标注点
            this.gMapControl1.Overlays.Add(markers);
        }




    }
}

