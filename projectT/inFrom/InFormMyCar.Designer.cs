
namespace projectT
{
    partial class InFormMyCar
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
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
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
            this.uiTableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.uiPanel1.Location = new System.Drawing.Point(123, 14);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 110;
            this.uiPanel1.Size = new System.Drawing.Size(730, 143);
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InFormMyCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(958, 759);
            this.Controls.Add(this.uiPanel1);
            this.Name = "InFormMyCar";
            this.Text = "InFormMyCar";
            this.Initialize += new System.EventHandler(this.InFormMyCar_Initialize);
            this.Load += new System.EventHandler(this.InFormMyCar_Load);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel1;
    }
}