using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectT.MyDialog
{
    public partial class AddParkInfo : UIEditForm
    {
        public static string location = null;
        public static int parkMaxNum = -1;
        public AddParkInfo()
        {
            InitializeComponent();
        }
        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // 阻止空格键输入
            }
        }
        protected override bool CheckData()
        {
            location = TextBox1.Text;
            parkMaxNum = uiIntegerUpDown1.Value;
            return CheckEmpty(TextBox1, "请输入停车场位置描述")
                   && parkMaxNum > 0;

        }
    }
}
