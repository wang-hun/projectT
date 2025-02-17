
using System.Windows.Forms;

namespace projectT
{
    partial class InFormMyPark
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InFormMyPark));
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.parkID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxParking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nowParking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opening = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.reFlashButton = new Sunny.UI.UIImageButton();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reFlashButton)).BeginInit();
            this.SuspendLayout();
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiAvatar1.AvatarSize = 130;
            this.uiAvatar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiAvatar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.uiAvatar1.Image = global::projectT.Properties.Resources.TT;
            this.uiAvatar1.Location = new System.Drawing.Point(217, 0);
            this.uiAvatar1.Margin = new System.Windows.Forms.Padding(0);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(143, 142);
            this.uiAvatar1.TabIndex = 0;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 26F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(0, 0);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(217, 142);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "username";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 26.29565F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.Olive;
            this.uiLabel3.Location = new System.Drawing.Point(360, 0);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(140, 142);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "User.";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 26F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiLabel1.Location = new System.Drawing.Point(500, 0);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(112, 142);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "000";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTableLayoutPanel1.ColumnCount = 4;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.27778F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.72222F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel1, 3, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel2, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel3, 2, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiAvatar1, 1, 0);
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(62, 0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(612, 142);
            this.uiTableLayoutPanel1.TabIndex = 2;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiPanel1.Controls.Add(this.uiTableLayoutPanel1);
            this.uiPanel1.FillColor = System.Drawing.Color.RoyalBlue;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(113, 14);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 110;
            this.uiPanel1.Size = new System.Drawing.Size(730, 143);
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.parkID,
            this.location,
            this.maxParking,
            this.nowParking,
            this.opening});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(175, 202);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.RowHeadersWidth = 49;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowTemplate.Height = 25;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiDataGridView1.Size = new System.Drawing.Size(612, 429);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 4;
            this.uiDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.uiDataGridView1_CellFormatting);
            // 
            // parkID
            // 
            this.parkID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.parkID.DataPropertyName = "parkID";
            this.parkID.HeaderText = "编号";
            this.parkID.MinimumWidth = 6;
            this.parkID.Name = "parkID";
            this.parkID.ReadOnly = true;
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "位置";
            this.location.MinimumWidth = 6;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // maxParking
            // 
            this.maxParking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxParking.DataPropertyName = "maxParking";
            this.maxParking.HeaderText = "最大车位";
            this.maxParking.MinimumWidth = 6;
            this.maxParking.Name = "maxParking";
            this.maxParking.ReadOnly = true;
            // 
            // nowParking
            // 
            this.nowParking.DataPropertyName = "nowParking";
            this.nowParking.HeaderText = "当前停车";
            this.nowParking.MinimumWidth = 6;
            this.nowParking.Name = "nowParking";
            this.nowParking.ReadOnly = true;
            this.nowParking.Width = 120;
            // 
            // opening
            // 
            this.opening.DataPropertyName = "opening";
            this.opening.HeaderText = "是否开放";
            this.opening.MinimumWidth = 6;
            this.opening.Name = "opening";
            this.opening.ReadOnly = true;
            this.opening.Width = 120;
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Location = new System.Drawing.Point(104, 655);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 45;
            this.uiSymbolButton2.Size = new System.Drawing.Size(175, 79);
            this.uiSymbolButton2.Symbol = 61543;
            this.uiSymbolButton2.TabIndex = 6;
            this.uiSymbolButton2.Text = "增加停车场";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Maroon;
            this.uiSymbolButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.Maroon;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(697, 655);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 45;
            this.uiSymbolButton1.Size = new System.Drawing.Size(175, 79);
            this.uiSymbolButton1.Symbol = 61544;
            this.uiSymbolButton1.TabIndex = 7;
            this.uiSymbolButton1.Text = "删除停车场";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.DarkGreen;
            this.uiSymbolButton3.FillColor2 = System.Drawing.Color.Green;
            this.uiSymbolButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uiSymbolButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uiSymbolButton3.FillSelectedColor = System.Drawing.Color.Lime;
            this.uiSymbolButton3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton3.Location = new System.Drawing.Point(392, 655);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Radius = 45;
            this.uiSymbolButton3.Size = new System.Drawing.Size(175, 79);
            this.uiSymbolButton3.Symbol = 61457;
            this.uiSymbolButton3.TabIndex = 8;
            this.uiSymbolButton3.Text = "修改开放状态";
            this.uiSymbolButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton3.Click += new System.EventHandler(this.uiSymbolButton3_Click);
            // 
            // reFlashButton
            // 
            this.reFlashButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reFlashButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.reFlashButton.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reFlashButton.ForeColor = System.Drawing.Color.Red;
            this.reFlashButton.Image = ((System.Drawing.Image)(resources.GetObject("reFlashButton.Image")));
            this.reFlashButton.ImageHover = ((System.Drawing.Image)(resources.GetObject("reFlashButton.ImageHover")));
            this.reFlashButton.ImageOffset = new System.Drawing.Point(12, 5);
            this.reFlashButton.ImagePress = global::projectT.Properties.Resources.flash;
            this.reFlashButton.Location = new System.Drawing.Point(793, 349);
            this.reFlashButton.Name = "reFlashButton";
            this.reFlashButton.Size = new System.Drawing.Size(133, 144);
            this.reFlashButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reFlashButton.TabIndex = 112;
            this.reFlashButton.TabStop = false;
            this.reFlashButton.Text = "刷新";
            this.reFlashButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reFlashButton.Click += new System.EventHandler(this.reFlashButton_Click);
            // 
            // InFormMyPark
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(938, 894);
            this.Controls.Add(this.reFlashButton);
            this.Controls.Add(this.uiSymbolButton3);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.uiPanel1);
            this.Name = "InFormMyPark";
            this.Text = "InFormMyCar";
            this.Initialize += new System.EventHandler(this.InFormMyCar_Initialize);
            this.Load += new System.EventHandler(this.InFormMyCar_Load);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reFlashButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parkID;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxParking;
        private System.Windows.Forms.DataGridViewTextBoxColumn nowParking;
        private System.Windows.Forms.DataGridViewTextBoxColumn opening;
        private Sunny.UI.UISymbolButton uiSymbolButton3;

          private void uiDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 获取当前单元格所在的列名
            string columnName = uiDataGridView1.Columns[e.ColumnIndex].Name;

            // 检查是否是 "opening" 列
            if (columnName == "opening" && e.Value != null)
            {
                // 根据值设置颜色
                if (e.Value.ToString() == "开放")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Green; // 绿色
                }
                else if (e.Value.ToString() == "关闭")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Red; // 红色
                }
            }
        }

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Sunny.UI.UIImageButton reFlashButton;
    }


}