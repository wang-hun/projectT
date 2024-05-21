using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace projectT
{
    public class PublicClass
    {
        public static int userid=-1;//用户身份 0： 1： 2：
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
                currFrom = new Form0();
            }
            return currFrom;
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
                    fromsName.Add("个人信息");
                    ///
                    break;
            
            }
        }

    }
    
}
