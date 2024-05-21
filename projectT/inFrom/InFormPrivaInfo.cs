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
    public partial class InFormPrivaInfo : UIPage
    {
        public InFormPrivaInfo()
        {
            InitializeComponent();
        }

        private void InFormPrivaInfo_Load(object sender, EventArgs e)
        {
            uiLabel1.Text = PublicClass.userObject.Username;
            uiLabel3.Text = PublicClass.userObject.Name;
            uiLabel4.Text = PublicClass.userObject.Telnum;
            string id="未知";
            switch (PublicClass.userObject.Userid) {
                case 0:id = "车主"; break;
                case 1:id = "管理员"; break;
                case 2:id = "监管者"; break;
            }
            uiLabel2.Text = id;


        }

        private void InFormPrivaInfo_Initialize(object sender, EventArgs e)
        {

        }
    }
}
