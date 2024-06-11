
namespace projectT
{
    partial class EditUserInfo
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.nameTextBox1 = new Sunny.UI.UITextBox();
            this.telNumTextBox2 = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Size = new System.Drawing.Size(541, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(413, 12);
            this.btnCancel.Size = new System.Drawing.Size(43, 35);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(298, 12);
            this.btnOK.Size = new System.Drawing.Size(43, 35);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(69, 148);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 61484;
            this.uiSymbolLabel1.TabIndex = 2;
            this.uiSymbolLabel1.Text = "姓名";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(69, 272);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 62112;
            this.uiSymbolLabel2.TabIndex = 3;
            this.uiSymbolLabel2.Text = "电话";
            // 
            // nameTextBox1
            // 
            this.nameTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTextBox1.Location = new System.Drawing.Point(275, 148);
            this.nameTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.nameTextBox1.Name = "nameTextBox1";
            this.nameTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.nameTextBox1.ShowText = false;
            this.nameTextBox1.Size = new System.Drawing.Size(194, 35);
            this.nameTextBox1.TabIndex = 4;
            this.nameTextBox1.Text = "uiTextBox1";
            this.nameTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameTextBox1.Watermark = "";
            this.nameTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // telNumTextBox2
            // 
            this.telNumTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telNumTextBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.telNumTextBox2.Location = new System.Drawing.Point(275, 272);
            this.telNumTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telNumTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.telNumTextBox2.Name = "telNumTextBox2";
            this.telNumTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.telNumTextBox2.ShowText = false;
            this.telNumTextBox2.Size = new System.Drawing.Size(194, 35);
            this.telNumTextBox2.TabIndex = 5;
            this.telNumTextBox2.Text = "uiTextBox2";
            this.telNumTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.telNumTextBox2.Watermark = "";
            this.telNumTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // EditUserInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.telNumTextBox2);
            this.Controls.Add(this.nameTextBox1);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "EditUserInfo";
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.EditUserInfo_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel1, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel2, 0);
            this.Controls.SetChildIndex(this.nameTextBox1, 0);
            this.Controls.SetChildIndex(this.telNumTextBox2, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox nameTextBox1;
        private Sunny.UI.UITextBox telNumTextBox2;
    }
}