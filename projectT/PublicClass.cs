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
        /// <summary>
        /// (userid,uiform)窗口状态机。
        /// </summary>
        public static Dictionary<int, UIForm> fromsRe=new Dictionary<int, UIForm>();
        public static UIForm currFrom=null;
        public static UIForm loadForm(int id) {
            if (id == -1) return null;
            currFrom = fromsRe[id];
            return currFrom;
        
        }
        /// <summary>
        /// 程序初始化函数
        /// </summary>
        public static void start()
        {
            PublicClass.fromsRe.Add(0, new Form0());
        }

    }
    
}
