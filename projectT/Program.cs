using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace projectT
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PublicClass.start();
            ///测试
            ///
            Application.Run(new LoadForm());
            UIForm newFrom = PublicClass.loadForm();
            if (newFrom == null) return;
            Application.Run(newFrom); 
        }
        /// <summary>
        /// 关闭整个程序，除非出现运行错误，请勿使用！
        /// </summary>
        public static void CLOSE_APPLICATION() {
            Application.Exit();
        }
    }
}
