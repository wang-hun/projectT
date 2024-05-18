using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace projectT
{
    public partial class FormRegister : UIForm
    {
        public static int ID;
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            //界面显示初始化
            uiSymbolButton1.BringToFront();
            uiSymbolButton2.BringToFront();
            uiFlowLayoutPanel1.BringToFront();
            #region 流式布局显示顺序
            ///流式布局显示顺序
           
            uiFlowLayoutPanel1.Add(pictureBox6);        
            uiFlowLayoutPanel1.Add(uiLine2);
            uiFlowLayoutPanel1.Add(uiTableLayoutPanel1);
            uiFlowLayoutPanel1.Add(uiLabel1);
            uiFlowLayoutPanel1.Add(uiLine1);
            uiFlowLayoutPanel1.Add(uiTableLayoutPanel2);
            uiFlowLayoutPanel1.Add(uiLabel2);
            uiFlowLayoutPanel1.Add(uiTableLayoutPanel3);
            uiFlowLayoutPanel1.Add(uiLabel3);
 
            uiFlowLayoutPanel1.Add(pictureBox5);
            #endregion
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (this.ShowAskDialog("提示", "确定要退出吗？将不会保留您填写的信息。",UIStyle.Red)) {
                this.DialogResult = DialogResult.No;
                this.Close();
            };
        }

        private void uiTextBox1_Leave(object sender, EventArgs e)
        {
            codeINPUT();
        }
        /// <summary>
        /// 密码输入确定函数
        /// </summary>
        private void codeINPUT() {
            if (uiTextBox1.Text.Equals(String.Empty))
            {
                uiLabel1.Text = "密码不能为空！";
            }
            else if (!uiTextBox1.Text.Equals(uiTextBox2.Text))
            {
                uiLabel1.Text = "两次密码不一致！";
            }
            else
            {
                uiLabel1.Text = String.Empty;
            }

        }
        /// <summary>
        /// 个人信息输入确定函数
        /// </summary>
        private void infoINPUT()
        {
            if (uiTextBox4.Text.Equals(String.Empty))
            {
                uiLabel2.Text = "姓名不能为空！";
            }
            else if (!uiTextBox3.Text.Equals(String.Empty))
            {
                uiLabel2.Text = "电话不能为空";
            }
            else if(!Regex.IsMatch(uiTextBox3.Text, @"^\d+$"))
            {
                uiLabel2.Text = "请输入正确的电话号码！";
            }
            else
            {
                uiLabel2.Text = String.Empty;
            }

        }

        private void uiTextBox2_Leave(object sender, EventArgs e)
        {
            codeINPUT();
        }

        private void uiListBox1_Leave(object sender, EventArgs e)
        {
            switch (uiListBox1.SelectedIndex) {
                case 0: uiLabel3.Text = "身份不能为空"; break;
                default: 
                    uiLabel3.Text = "";
                    ID = uiListBox1.SelectedIndex - 1;
                    break;
            }
        }
    }
}
