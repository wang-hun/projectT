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
using System.IO;
using System.Net;


namespace projectT
{
    public partial class InFormPrivaInfo : UIPage
    {
    
        
      
        //错误取消，如果主窗口不是form0，一定出错
        /// <summary>
        /// 所有需要加载头像的加载
        /// </summary>
    
        public InFormPrivaInfo()
        {
            InitializeComponent();
        }
        public void Renew()
        {
            uiLabel1.Text = PublicClass.userObject.Username;
            uiLabel3.Text = PublicClass.userObject.Name;
            uiLabel4.Text = PublicClass.userObject.Telnum;
            string id = "未知";
            switch (PublicClass.userObject.Userid)
            {
                case 0: id = "车主"; break;
                case 1: id = "管理员"; break;
                case 2: id = "监管者"; break;
            }
            uiLabel2.Text = id;
            changeQQtag();
        }
        private void InFormPrivaInfo_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            Renew();

        }
        private void changeQQtag() {
            
            if (PublicClass.userObject.QqID==null|| PublicClass.userObject.QqID.Equals(String.Empty))
            {
                uiPanel3.Show();
                uiPanel4.Hide();
            }
            else {
                uiPanel3.Hide();
                uiPanel4.Show();
                uiLabel6.Text = PublicClass.userObject.QqID;

                PublicClass.LoadImageFromUrl(this.uiAvatar2, "http://q1.qlogo.cn/g?b=qq&nk="+ PublicClass.userObject.QqID+"&s=640");
            }
        
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

        private void uiSymbolButton1_Click_1(object sender, EventArgs e)
        {

           
                string value = "请输入qq用户名";
                if (this.ShowInputStringDialog(ref value, true, "请输入qq用户名：", true))
                {
                bool f1 = Regex.IsMatch(value, @"^[1-9]\d{4,9}$");
                if (f1)
                {
                    PublicClass.userObject.QqID = value;
                    SQLClass.ExecuteReader("UPDATE users SET qqID=" + "'" + PublicClass.userObject.QqID+ "' WHERE user=" + "'" + PublicClass.userObject.Username + "'");
                    changeQQtag();
                }
                else {
                    this.ShowInfoDialog("QQ用户名格式错误！");
                }
                }
            
        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            if (this.ShowAskDialog("你确定要取消QQ号的绑定吗")) {
                PublicClass.userObject.QqID = null;
                SQLClass.ExecuteReader("UPDATE users SET qqID=" + "NULL WHERE user=" + "'" + PublicClass.userObject.Username + "'");
                changeQQtag();
            }
        }
    }
}
