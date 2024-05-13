
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
            // LoadForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::projectT.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.CloseAskString = "";
            this.EscClose = false;
            this.Name = "LoadForm";
            this.ShowInTaskbar = true;
            this.SubText = "智能停车管理系统 V0.0.0.1";
            this.Text = "LoadForm";
            this.Title = "智能停车管理系统";
            this.ButtonCancelClick += new System.EventHandler(this.LoadForm_ButtonCancelClick);
            this.OnLogin += new Sunny.UI.UILoginForm.OnLoginHandle(this.LoadForm_OnLogin);
            this.Load += new System.EventHandler(this.LoadForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}