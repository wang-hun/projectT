
namespace projectT
{
    partial class EditPassword
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
            this.TextBox2 = new Sunny.UI.UITextBox();
            this.TextBox1 = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
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
            this.btnCancel.Location = new System.Drawing.Point(379, 12);
            this.btnCancel.Radius = 1;
            this.btnCancel.Size = new System.Drawing.Size(128, 35);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(170, 12);
            this.btnOK.Radius = 1;
            this.btnOK.Size = new System.Drawing.Size(129, 35);
            // 
            // TextBox2
            // 
            this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox2.Location = new System.Drawing.Point(277, 270);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox2.PasswordChar = '*';
            this.TextBox2.ShowText = false;
            this.TextBox2.Size = new System.Drawing.Size(194, 35);
            this.TextBox2.TabIndex = 9;
            this.TextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBox2.Watermark = "";
            this.TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // TextBox1
            // 
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox1.Location = new System.Drawing.Point(277, 146);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.TextBox1.PasswordChar = '*';
            this.TextBox1.ShowText = false;
            this.TextBox1.Size = new System.Drawing.Size(194, 35);
            this.TextBox1.TabIndex = 8;
            this.TextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBox1.Watermark = "";
            this.TextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel2.Location = new System.Drawing.Point(71, 270);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 61553;
            this.uiSymbolLabel2.TabIndex = 7;
            this.uiSymbolLabel2.Text = "确认密码";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSymbolLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(71, 146);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 61546;
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "新密码";
            // 
            // EditPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "EditPassword";
            this.Text = "密码设置";
            this.CheckedData += new Sunny.UI.UIEditForm.OnCheckedData(this.EditPassword_CheckedData);
            this.Load += new System.EventHandler(this.EditPassword_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel1, 0);
            this.Controls.SetChildIndex(this.uiSymbolLabel2, 0);
            this.Controls.SetChildIndex(this.TextBox1, 0);
            this.Controls.SetChildIndex(this.TextBox2, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox TextBox2;
        private Sunny.UI.UITextBox TextBox1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}