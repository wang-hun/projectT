﻿
namespace projectT
{
    partial class LoadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.uiLinkLabel1 = new Sunny.UI.UILinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "智能停车管理系统";
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(433, 426);
            this.lblSubText.Text = "智能停车管理系统 V0.0.0.1";
            // 
            // uiLinkLabel1
            // 
            this.uiLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLinkLabel1.DisabledLinkColor = System.Drawing.Color.Red;
            this.uiLinkLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLinkLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.uiLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.uiLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uiLinkLabel1.Location = new System.Drawing.Point(433, 376);
            this.uiLinkLabel1.Name = "uiLinkLabel1";
            this.uiLinkLabel1.Size = new System.Drawing.Size(194, 23);
            this.uiLinkLabel1.TabIndex = 10;
            this.uiLinkLabel1.TabStop = true;
            this.uiLinkLabel1.Text = "新用户？点此注册。";
            this.uiLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiLinkLabel1.Click += new System.EventHandler(this.uiLinkLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::projectT.Properties.Resources.TT;
            this.pictureBox1.Location = new System.Drawing.Point(181, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::projectT.Properties.Resources.bg1;
            this.ButtonCancelText = "退出";
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.CloseAskString = "";
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiLinkLabel1);
            this.EscClose = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadForm";
            this.ShowInTaskbar = true;
            this.SubText = "智能停车管理系统 V0.0.0.1";
            this.Text = "LoadForm";
            this.Title = "智能停车管理系统";
            this.ButtonCancelClick += new System.EventHandler(this.LoadForm_ButtonCancelClick);
            this.OnLogin += new Sunny.UI.UILoginForm.OnLoginHandle(this.LoadForm_OnLogin);
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.Controls.SetChildIndex(this.uiLinkLabel1, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.lblSubText, 0);
            this.Controls.SetChildIndex(this.uiPanel1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILinkLabel uiLinkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}