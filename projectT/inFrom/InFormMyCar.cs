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
    public partial class InFormMyCar : UIPage
    {
        public InFormMyCar()
        {
            InitializeComponent();
        }
        public void Renew() {
            uiLabel2.Text = PublicClass.userObject.Name;
            uiLabel1.Text = PublicClass.userObject.Username;
            if (PublicClass.userObject.QqID == null || PublicClass.userObject.QqID.Equals(String.Empty))
                this.uiAvatar1.Image = projectT.Properties.Resources.TT;
            else
            {
                PublicClass.LoadImageFromUrl(this.uiAvatar1, "http://q1.qlogo.cn/g?b=qq&nk=" + PublicClass.userObject.QqID + "&s=640");
            }
        }
        private void InFormMyCar_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            Renew();
        }
        public UIAvatar ThisAvatar() {
            return this.uiAvatar1;
        }

        private void InFormMyCar_Initialize(object sender, EventArgs e)
        {

        }
    }
}
