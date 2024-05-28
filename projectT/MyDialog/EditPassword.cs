using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace projectT
{
    public partial class EditPassword : UIEditForm
    {
        public static string password = null;
        public EditPassword()
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
        private void EditPassword_Load(object sender, EventArgs e)
        {

        }

        private bool EditPassword_CheckedData(object sender, EditFormEventArgs e)
        {
            bool f1 = TextBox1.Text.Equals(TextBox2.Text);
            if (!f1)
            {
                this.ShowErrorDialog("两次密码不一致");
            }
            password = TextBox2.Text;
            //tel = telNumTextBox2.Text;
            return CheckEmpty(TextBox1, "请输入密码")
                   && CheckEmpty(TextBox2, "请确认密码")
                   && f1;
        }
    }
}
