using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sunny.UI;


namespace projectT
{
    public partial class LoadForm : UILoginForm
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        private void LoadForm_Load(object sender, EventArgs e)
        {
           
        }
    


        private void LoadForm_ButtonCancelClick(object sender, EventArgs e)
        {
            if (this.ShowAskDialog("您确定要退出本系统吗"))
            {
                this.Close();
            }
        }

        
        private bool LoadForm_OnLogin(string userName, string password)
        {
            if (userName == string.Empty)
            {
                this.ShowErrorNotifier("Error 用户名不能为空");
                return false;
            }
            else if (password == string.Empty) {
                this.ShowErrorNotifier("Error 密码不能为空");
                return false;
            }
            int userIdentity = -1;
            string userNameFromDatabase;
            // 首先检查用户名是否存在
            MySqlDataReader userExistenceReader = SQLClass.ExecuteReader("SELECT COUNT(*) FROM users WHERE user = \""+userName+"\"");
            userExistenceReader.Read();
            int userCount = userExistenceReader.GetInt32(0);
            userExistenceReader.Close();

            if (userCount > 0)
            {
                // 用户名存在，进一步验证密码
                MySqlDataReader loginReader = SQLClass.ExecuteReader("SELECT identity, name FROM users WHERE user = \"" + userName+ "\"" + "AND passcode =\"" + password + "\"");
                if (loginReader.Read())
                {
                    userIdentity = loginReader.GetInt32(loginReader.GetOrdinal("identity"));
                    userNameFromDatabase = loginReader.GetString(loginReader.GetOrdinal("name"));
               
                    loginReader.Close();
                   
                    this.ShowSuccessDialog("欢迎！" + userNameFromDatabase, false, 5000);
                    
                    PublicClass.userid = userIdentity;
                    //打开一个新窗体 
                    PublicClass.user = userName;

                    return true; // 登录成功
                }
                else
                {
                    loginReader.Close();
                    this.ShowErrorNotifier("Error 密码错误");
                    return false; // 密码错误
                }
            }
            else
            {
                this.ShowErrorNotifier("Error 用户名不存在");
                return false; // 用户名不存在
            }
        }

        private void uiLinkLabel1_Click(object sender, EventArgs e)
        {
            FormRegister regFrom = new FormRegister();
            this.Hide();
            if (regFrom.ShowDialog()==DialogResult.Yes){
                
            }
            this.Show();
        }
        private int angle = 10; 

        private void timer1_Tick(object sender, EventArgs e)
        {

            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Invalidate();
        }
        
    }
}
