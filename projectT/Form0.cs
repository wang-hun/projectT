using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace projectT
{
    public partial class Form0 : UIHeaderAsideMainFrame
    {
        private Thread th=null;//加载线程
        private const int StartinID = 1001;//from的id必须唯一，切记！切记！切记！
        private int inFromID = 1001;//from的id必须唯一，切记！切记！切记！
        public Form0()
        {
            InitializeComponent();
            //设置关联
            th = new Thread(() =>
            {

                this.ShowStatusForm(100, "数据加载中......", 0);
                for (int i = 0; i < 90; i += 5)
                {
                    SystemEx.Delay(100);
                    this.SetStatusFormDescription("数据加载中(" + i + "%)......");
                    this.SetStatusFormStepIt(5);

                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            th.Start();
            pictureBox1.BringToFront();
            uiLabel1.BringToFront();
            uiLabel2.BringToFront();
            
            Aside.TabControl = MainTabControl;

            #region 使用示例
            //增加页面到Main
            //AddPage(new FTitlePage1(), 1001);
            //AddPage(new FTitlePage2(), 1002);
            // AddPage(new FTitlePage3(), 1003);

            //设置Header节点索引
            //Aside.CreateNode("Page1", 1001);
            //Aside.CreateNode("Page2", 1002);
            //Aside.CreateNode("Page3", 1003);
            #endregion
            PublicClass.loadInFrom();
            for (int i=0;i<PublicClass.infroms.Count ;i++)
            {
                AddPage(PublicClass.infroms[i], inFromID);
                Aside.CreateNode(PublicClass.fromsName[i], inFromID);
                inFromID++;
            }
            Aside.SelectFirst();
            ///加载部分完成
            Thread.Sleep(500); 
            th.Abort();
                 
            this.HideStatusForm();
        }

        private void Form0_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ShowAskDialog("你确定要退出吗"))
            {
               
            }
            else {
                e.Cancel = true;
            }
        }
    }
}
