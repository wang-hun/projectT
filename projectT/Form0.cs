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
    public partial class Form0 : UIForm
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowStatusForm(100, "数据加载中......", 0);
            for (int i = 0; i < 88; i++)
            {
                SystemEx.Delay(50);
                this.SetStatusFormDescription("数据加载中(" + i + "%)......");
                this.SetStatusFormStepIt();
            }

            this.HideStatusForm();
        }
    }
}
