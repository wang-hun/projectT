using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sunny.UI;

namespace projectT
{
    public class PublicClass
    {
        public static int userid=-1;//用户身份 0： 1： 2：
        public static UserObject userObject;
        public static string user;
        public static List<UIPage> infroms = new List<UIPage>();
        public static List<string> fromsName = new List<string>();
        /// <summary>
        /// (userid,uiform)窗口状态机。
        /// </summary>
        //public static Dictionary<int, UIForm> fromsRe=new Dictionary<int, UIForm>();
        public static UIForm currFrom=null;
        /// <summary>
        /// 系统总界面加载
        /// </summary>
        /// <returns>系统总界面(单例)</returns>
        public static UIForm loadForm()
        {
            if (userid == -1) {
                return null;
            }
            if (currFrom==null) {
                userObject = new UserObject(userid);
                userObject.userLoad(user);
                currFrom = new Form0();
            }
            return currFrom;
        }
        /// <summary>
        /// 图片变暗，变亮
        /// </summary>
        /// <param name="original"></param>
        /// <param name="brightness"></param>
        /// <returns></returns>
        public static Image AdjustBrightness(Image original, float brightness)
        {
            Bitmap bmp = new Bitmap(original);
            ColorMatrix matrix = new ColorMatrix(new float[][]{
            new float[] {1, 0, 0, 0, 0},
            new float[] {0, 1, 0, 0, 0},
            new float[] {0, 0, 1, 0, 0},
            new float[] {0, 0, 0, 1, 0},
            new float[] {brightness, brightness, brightness, 0, 1} }
        );

            using (ImageAttributes attributes = new ImageAttributes())
            {
                attributes.SetColorMatrix(matrix);
                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    graphics.DrawImage(original, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return bmp;
        }
        /// <summary>
        /// 头像加载函数
        /// </summary>
        /// <param name="avatar">头像框</param>
        /// <param name="imageUrl">图片url</param>
        public static void LoadImageFromUrl(UIAvatar avatar, string imageUrl)
        {
            using (WebClient client = new WebClient())
            {
                byte[] imageData = client.DownloadData(imageUrl);
                using (MemoryStream stream = new MemoryStream(imageData))
                {
                    avatar.Image = Image.FromStream(stream);
                }
            }
        }
      
        /*已废弃，主窗口保持不变，功能由page切换所取代
        public static UIForm loadForm(int id) {
            if (id == -1) return null;
            currFrom = fromsRe[id];
            return currFrom;
        
        }*/
        /// <summary>
        /// 程序初始化函数
        /// </summary>
        public static void start()
        {
            //PublicClass.fromsRe.Add(0, new Form0());
        }
        public static void loadInFrom() {
            infroms.ForEach(ifrom=> {
                ifrom = null;
            });
            infroms.Clear();
            fromsName.Clear();
            switch (userid) {
                case 0:
                    ///车主的嵌入式界面加载
                    infroms.Add(new InFormPrivaInfo());
                    infroms.Add(new InFormMyCar());
                    infroms.Add(new InFormFindPark());
                    fromsName.Add("个人信息");
                    fromsName.Add("车辆信息");
                    fromsName.Add("查看停车场");
                    ///
                    break;
                case 1:
                    ///停车场管理员的嵌入式界面加载
                    infroms.Add(new InFormPrivaInfo());
                    infroms.Add(new InFormMyPark());
                    fromsName.Add("个人信息");
                    fromsName.Add("停车场信息");
                    break;
                case 2:
                    ///监管者的嵌入式界面加载
                  
                    break;
            }
        }

    }
   public class UserObject {
        //用户对象
        int userid = -1;//用户身份 0： 1： 2：
        string name;//用户名字
        string telnum;//电话号码
        string username;//用户名，账号，不是用户的名字！！！
        string password;//密码
        string qqID;
        //待补充
        /// <summary>
        /// 用户数据加载
        /// </summary>
        /// <param name="usName">用户名，账号</param>
        public void userLoad(string usName) {
          MySqlDataReader ds=SQLClass.ExecuteReader("SELECT * FROM users WHERE user=\""+usName+"\"");

            try
            {
                if (ds.Read())
                {
                    this.username =usName;
                    this.name = ds.GetString("name");
                    this.telnum = ds.GetString("telnum");
                    this.password = ds.GetString("passcode");
                    this.qqID = ds.IsDBNull(ds.GetOrdinal("qqID")) ? null : ds.GetString("qqID"); ;
                }
                else
                {
                    MessageBox.Show("用户名未找到", "警告");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库无法连接，请联系管理员。\n"+ex, "错误");
                Program.CLOSE_APPLICATION();
            }
        }
        
        /// <param name="userid">用户身份</param>
        public UserObject(int userid)
        {
            this.userid = userid;
        }

        public UserObject(int userid, string name, string telnum, string username, string password)
        {
            this.userid = userid;
            this.name = name;
            this.telnum = telnum;
            this.username = username;
            this.password = password;
        }

        public int Userid { get => userid; set => userid = value; }
        public string Name { get => name; set => name = value; }
        public string Telnum { get => telnum; set => telnum = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string QqID { get => qqID; set => qqID = value; }
    }
    
}
