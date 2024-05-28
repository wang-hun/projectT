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

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string value = "";
            if (this.ShowInputPasswordDialog(ref value))
            {
                if (value.Equals(PublicClass.userObject.Password))
                {
                    EditUserInfo frm = new EditUserInfo();
                    frm.Render();
                    frm.ShowDialog();
                    if (frm.IsOK)
                    {
                        PublicClass.userObject.Name = EditUserInfo.name;
                        PublicClass.userObject.Telnum = EditUserInfo.tel;
                        uiLabel3.Text = PublicClass.userObject.Name;
                        uiLabel4.Text = PublicClass.userObject.Telnum;
                       SQLClass.ExecuteReader("UPDATE users SET name=" + "'"+ PublicClass.userObject.Name + "' ,"+ " telnum=" + "'" + PublicClass.userObject.Telnum + "' WHERE user=" + "'" + PublicClass.userObject.Username + "'");
        
                        this.ShowSuccessDialog("修改成功！");
                    }
                    frm.Dispose();
                }
                else {
                    this.ShowErrorDialog("错误","密码错误");
                }
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            string value = "";
            if (this.ShowInputPasswordDialog(ref value))
            {
                if (value.Equals(PublicClass.userObject.Password))
                {
                    EditPassword frm = new EditPassword();
                    frm.Render();
                    frm.ShowDialog();
                    if (frm.IsOK)
                    {
                        PublicClass.userObject.Password = EditPassword.password;
                        SQLClass.ExecuteReader("UPDATE users SET passcode=" + "'" + PublicClass.userObject.Password + "' WHERE user=" + "'" + PublicClass.userObject.Username + "'");

                        this.ShowSuccessDialog("修改成功！");
                    }
                    frm.Dispose();
                }
                else
                {
                    this.ShowErrorDialog("错误", "密码错误");
                }
            }
        }
    }
}
