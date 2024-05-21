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
            Application.Run(new LoadForm());
            UIForm newFrom = PublicClass.loadForm();
            if (newFrom == null) return;
            Application.Run(newFrom); 
        }
    }
}
