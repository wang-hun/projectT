
namespace projectT
{
    partial class AddParkLoca
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
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 699);
            this.pnlBtm.Size = new System.Drawing.Size(1139, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1011, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(896, 12);
            // 
            // AddParkLoca
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1141, 757);
            this.Name = "AddParkLoca";
            this.Text = "选择停车场位置";
            this.Load += new System.EventHandler(this.AddParkLoca_Load);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}