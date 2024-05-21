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
using MySql.Data.MySqlClient;
using Sunny.UI;

namespace projectT
{
  
    public partial class FormRegister : UIForm
    {
        bool[] sws = new bool[]{false,false,false}; 
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
                sws[0] = false;
            }
            else if (!Regex.IsMatch(uiTextBox1.Text, @"^[A-Za-z0-9@]+$")) // 检查是否只包含字母、数字、@
            {
                uiLabel1.Text = "密码只能包含字母、数字、@";
                sws[0] = false;
            }
            else if (!uiTextBox1.Text.Equals(uiTextBox2.Text))
            {
                uiLabel1.Text = "两次密码不一致！";
                sws[0] = false;
            }
            else
            {
                sws[0] = true;
                uiLabel1.Text = String.Empty;
            }

        }
        //不被接受空格的输入
        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // 阻止空格键输入
            }
        }
        /// <summary>
        /// 个人信息输入确定函数
        /// </summary>
        private void infoINPUT()
        {
            uiTextBox3.Text= uiTextBox3.Text.Replace(" ", "");
            uiTextBox4.Text= uiTextBox4.Text.Replace(" ", "");
            if (uiTextBox4.Text.Equals(String.Empty))
            {
                uiLabel2.Text = "姓名不能为空！";
                sws[1] = false;
            }
            else if (uiTextBox3.Text.Equals(String.Empty))
            {
                uiLabel2.Text = "电话不能为空";
                sws[1] = false;
            }
            else if(!Regex.IsMatch(uiTextBox3.Text, @"^\d+$"))
            {
                uiLabel2.Text = "请输入正确的电话号码！";
                sws[1] = false;
            }
            else
            {
                sws[1] = true;
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
                case 0: uiLabel3.Text = "身份不能为空";
                        sws[2] = false; 
                        break;
                default: 
                    uiLabel3.Text = "";
                    sws[2] = true;
                    // ID = uiListBox1.SelectedIndex - 1;
                    break;
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
          
            if (sws[0] && sws[1] && sws[2]) {
              MySqlDataReader ds= SQLClass.ExecuteReader("select * from  users ORDER BY sub DESC LIMIT 1");
              ds.Read();
                    int useridI = Convert.ToInt32(ds.GetString("user")) + 1;
                    string useridSTR;
                    if (useridI < 10)
                    {
                        useridSTR = "00" + useridI;
                    }
                    else if (useridI < 100)
                    {
                        useridSTR = "0" + useridI;
                    }
                    else
                    {
                        useridSTR = "" + useridI;
                    }
                    User.getUser(uiListBox1.SelectedIndex - 1,uiTextBox4.Text, uiTextBox3.Text, useridSTR, uiTextBox2.Text);
                    if (User.SQLINSERT()) {
                        this.ShowInfoDialog("注册成功","您用于登录的用户名为：" + useridSTR+"\n欢迎您"+" "+User.getUser().name);
                        this.Close();
                    }
              
                
            }//信息不符合条件什么都不会发生
        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            if (uiSymbolButton4.Symbol == 261550)
            {
                uiSymbolButton4.Symbol = 261552;
                uiTextBox2.PasswordChar = '\0';

            }
            else {

                uiSymbolButton4.Symbol = 261550;
                uiTextBox2.PasswordChar = '·';
            }
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            if (uiSymbolButton3.Symbol == 261550)
            {
                uiSymbolButton3.Symbol = 261552;
                uiTextBox1.PasswordChar = '\0';

            }
            else
            {

                uiSymbolButton3.Symbol = 261550;
                uiTextBox1.PasswordChar = '·';
            }
        }

        private void uiTextBox4_Leave(object sender, EventArgs e)
        {
            infoINPUT();
        }

        private void uiTextBox3_Leave(object sender, EventArgs e)
        {
            infoINPUT();
        }
    }
    public class User
    {
        public int ID;
        public string name;
        public string tel;
        public string userID;
        public string password;
        private static User user;

        public User()
        {

        }

        public User(int iD, string name, string tel, string userID, string password)
        {
            ID = iD;
            this.name = name;
            this.tel = tel;
            this.userID = userID;
            this.password = password;
        }

        public static User getUser()
        {

            if (user == null)
            {
                user = new User();
            }
            return user;
        }
        public static User getUser(int iD, string name, string tel, string userID, string password)
        {

            if (user == null)
            {
                user = new User(iD, name, tel, userID, password);
            }
            return user;
        }
        public void freeUser()
        {
            user = null;
        }

        public static bool SQLINSERT() {
            try{
               int n= SQLClass.ExecuteSql("INSERT INTO `users`(`user`, `passcode`, `telnum`, `name`, `identity`) VALUES ('"+user.userID+"', '"+user.password+"', '"+ user.tel+ "', '" + user.name + "', " + user.ID + ")");
                if (n==1) {
                    return true;
                }
                else {
                    MessageBox.Show("数据库写入错误,写入行数为0 in USER.SQLINSERT()");//希望不会发生这种情况
                    return false;
                }
            }catch (Exception e) {
                MessageBox.Show("数据库写入错误 in USER.SQLINSERT()"+e);//希望不会发生这种情况
                return false;
            }
        
        
        }
    }
}
