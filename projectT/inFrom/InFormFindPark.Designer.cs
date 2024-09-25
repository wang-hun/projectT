
using System.Windows.Forms;

namespace projectT
{
    partial class InFormFindPark
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
            Sunny.UI.UILine uiLine5;
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiLedLabel4 = new Sunny.UI.UILedLabel();
            this.uiBattery1 = new Sunny.UI.UIBattery();
            this.uiDigitalLabel1 = new Sunny.UI.UIDigitalLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            uiLine5 = new Sunny.UI.UILine();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLine5
            // 
            uiLine5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            uiLine5.BackColor = System.Drawing.Color.Transparent;
            uiLine5.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            uiLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            uiLine5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            uiLine5.LineColorGradient = true;
            uiLine5.Location = new System.Drawing.Point(0, 87);
            uiLine5.MinimumSize = new System.Drawing.Size(16, 16);
            uiLine5.Name = "uiLine5";
            uiLine5.Size = new System.Drawing.Size(740, 54);
            uiLine5.TabIndex = 59;
            uiLine5.Text = "剩余停车位";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(106, 166);
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
            this.gMapControl1.Size = new System.Drawing.Size(648, 395);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiImageButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiImageButton1.Image = global::projectT.Properties.Resources.YESOD;
            this.uiImageButton1.Location = new System.Drawing.Point(561, 12);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(330, 130);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 1;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = "查询";
            this.uiImageButton1.Click += new System.EventHandler(this.uiImageButton1_Click);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.uiTextBox1.Location = new System.Drawing.Point(106, 63);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(448, 29);
            this.uiTextBox1.TabIndex = 2;
            this.uiTextBox1.Text = "请输入位置说明";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            this.uiTextBox1.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            this.uiTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiTextBox1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.uiLedLabel4);
            this.panel1.Controls.Add(this.uiBattery1);
            this.panel1.Controls.Add(this.uiDigitalLabel1);
            this.panel1.Controls.Add(uiLine5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(106, 648);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 393);
            this.panel1.TabIndex = 3;
            // 
            // uiLedLabel4
            // 
            this.uiLedLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiLedLabel4.BackColor = System.Drawing.Color.Black;
            this.uiLedLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLedLabel4.ForeColor = System.Drawing.Color.Lime;
            this.uiLedLabel4.IntervalOn = 3;
            this.uiLedLabel4.Location = new System.Drawing.Point(266, 281);
            this.uiLedLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel4.Name = "uiLedLabel4";
            this.uiLedLabel4.Size = new System.Drawing.Size(208, 42);
            this.uiLedLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLedLabel4.StyleCustomMode = true;
            this.uiLedLabel4.TabIndex = 110;
            this.uiLedLabel4.Text = "NULL";
            // 
            // uiBattery1
            // 
            this.uiBattery1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiBattery1.BackColor = System.Drawing.Color.Transparent;
            this.uiBattery1.FillColor = System.Drawing.Color.Transparent;
            this.uiBattery1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiBattery1.Location = new System.Drawing.Point(480, 271);
            this.uiBattery1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBattery1.Name = "uiBattery1";
            this.uiBattery1.Power = 23;
            this.uiBattery1.Size = new System.Drawing.Size(91, 65);
            this.uiBattery1.SymbolSize = 80;
            this.uiBattery1.TabIndex = 109;
            this.uiBattery1.Text = "uiBattery1";
            // 
            // uiDigitalLabel1
            // 
            this.uiDigitalLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiDigitalLabel1.BackColor = System.Drawing.Color.Black;
            this.uiDigitalLabel1.DecimalPlaces = 0;
            this.uiDigitalLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDigitalLabel1.ForeColor = System.Drawing.Color.Lime;
            this.uiDigitalLabel1.Location = new System.Drawing.Point(266, 147);
            this.uiDigitalLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDigitalLabel1.Name = "uiDigitalLabel1";
            this.uiDigitalLabel1.Size = new System.Drawing.Size(208, 42);
            this.uiDigitalLabel1.TabIndex = 108;
            this.uiDigitalLabel1.Text = "uiDigitalLabel1";
            this.uiDigitalLabel1.TextOffset = new System.Drawing.Point(6, 0);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(285, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "停车位使用率";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(249, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "请选择一个停车场";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(296, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "停车场描述";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(289, 602);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择一个停车场，查看相关信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.27826F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(101, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "输入查询信息，查询对应停车场";
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Location = new System.Drawing.Point(770, 466);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 50;
            this.uiSymbolButton2.Size = new System.Drawing.Size(105, 95);
            this.uiSymbolButton2.Symbol = 61544;
            this.uiSymbolButton2.SymbolSize = 50;
            this.uiSymbolButton2.TabIndex = 7;
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(770, 166);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 50;
            this.uiSymbolButton1.Size = new System.Drawing.Size(105, 95);
            this.uiSymbolButton1.Symbol = 61543;
            this.uiSymbolButton1.SymbolSize = 50;
            this.uiSymbolButton1.TabIndex = 8;
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // InFormFindPark
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(938, 1091);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiImageButton1);
            this.Controls.Add(this.gMapControl1);
            this.Name = "InFormFindPark";
            this.Text = "InFormFindPark";
            this.Load += new System.EventHandler(this.InFormFindPark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Sunny.UI.UIImageButton uiImageButton1;
        private Sunny.UI.UITextBox uiTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Label label6;
        private Label label4;
        private Label label3;
        private Sunny.UI.UIDigitalLabel uiDigitalLabel1;
        private Sunny.UI.UILedLabel uiLedLabel4;
        private Sunny.UI.UIBattery uiBattery1;
    }
}