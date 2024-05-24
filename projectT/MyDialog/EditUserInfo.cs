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
    public partial class EditUserInfo : UIEditForm
    {
       public static string tel = null;
        public static string name = null;
        public EditUserInfo()
        {
            InitializeComponent();
        }
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // 阻止空格键输入
            }
        }
        protected override bool CheckData()
        {
           
            bool f1 = Regex.IsMatch(telNumTextBox2.Text, @"^\d+$");
            if (!f1)
            {
                this.ShowErrorDialog("输入合法手机号");
            }
            name = nameTextBox1.Text;
            tel = telNumTextBox2.Text;
            return CheckEmpty(nameTextBox1, "请输入姓名")
                   && CheckEmpty(telNumTextBox2, "请输入电话")
                   && f1;
                   
        }

        private void EditUserInfo_Load(object sender, EventArgs e)
        {
            this.nameTextBox1.Text = PublicClass.userObject.Name;
            this.telNumTextBox2.Text = PublicClass.userObject.Telnum;
        }
    }
}
