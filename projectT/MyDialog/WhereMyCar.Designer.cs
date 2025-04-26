
namespace projectT
{
    partial class WhereMyCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.uiSignal6 = new Sunny.UI.UISignal();
            this.uiLedBulb4 = new Sunny.UI.UILedBulb();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 531);
            this.pnlBtm.Size = new System.Drawing.Size(1024, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(896, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(781, 12);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(210, 38);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(787, 485);
            this.gMapControl1.TabIndex = 2;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // uiSignal6
            // 
            this.uiSignal6.Font = new System.Drawing.Font("宋体", 12F);
            this.uiSignal6.Location = new System.Drawing.Point(4, 38);
            this.uiSignal6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSignal6.Name = "uiSignal6";
            this.uiSignal6.Size = new System.Drawing.Size(35, 35);
            this.uiSignal6.TabIndex = 94;
            this.uiSignal6.Text = "uiSignal6";
            // 
            // uiLedBulb4
            // 
            this.uiLedBulb4.Blink = true;
            this.uiLedBulb4.BlinkInterval = 500;
            this.uiLedBulb4.Location = new System.Drawing.Point(45, 38);
            this.uiLedBulb4.Name = "uiLedBulb4";
            this.uiLedBulb4.On = false;
            this.uiLedBulb4.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb4.TabIndex = 95;
            this.uiLedBulb4.Text = "uiLedBulb4";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(18, 104);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 61484;
            this.uiSymbolLabel1.TabIndex = 96;
            this.uiSymbolLabel1.Text = "车牌号";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(18, 242);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 61484;
            this.uiSymbolLabel2.TabIndex = 97;
            this.uiSymbolLabel2.Text = "停放位置";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(18, 368);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel3.Symbol = 61484;
            this.uiSymbolLabel3.TabIndex = 98;
            this.uiSymbolLabel3.Text = "停放时间";
            // 
            // WhereMyCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1026, 589);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiLedBulb4);
            this.Controls.Add(this.uiSignal6);
            this.Controls.Add(this.gMapControl1);
            this.Name = "WhereMyCar";
            this.Text = "选择所在位置";
            this.Controls.SetChildIndex(this.gMapControl1, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiSignal6, 0);
            this.Controls.SetChildIndex(this.uiLedBulb4, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel1, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel2, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel3, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Sunny.UI.UISignal uiSignal6;
        private Sunny.UI.UILedBulb uiLedBulb4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
    }
}