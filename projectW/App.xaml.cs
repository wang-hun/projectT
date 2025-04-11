using projectT;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace projectW
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public int pageIndex {  get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // 第一步：显示加载窗口
            var selectWindow = new SelectWindow();
            selectWindow.app=this;
            selectWindow.ShowDialog(); // 模态显示

            // 第二步：获取主窗口
            var mainWindow = this.SelectShow(pageIndex);
            if (mainWindow != null)
            {
                mainWindow.Show();
            }
          
        }

        public Window SelectShow(int x) 
        {
            if (x == 1)
            {
                return new Addparking();
            }
            else if (x == 2)
            { 
            return new InOutWindow();
            }
            else return null;
        }

        // 全局关闭方法
        public static void CloseApplication()
        {
            Current.Dispatcher.Invoke(() => Current.Shutdown());
        }
    }
}
