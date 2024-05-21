using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace projectT
{
    public partial class Form0 : UIHeaderAsideMainFrame
    {
        private const int StartinID = 1001;//from的id必须唯一，切记！切记！切记！
        private int inFromID = 1001;//from的id必须唯一，切记！切记！切记！
        public Form0()
        {
            InitializeComponent();
            //设置关联
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowStatusForm(100, "数据加载中......", 0);
            for (int i = 0; i < 88; i++)
            {
                SystemEx.Delay(50);
                this.SetStatusFormDescription("数据加载中(" + i + "%)......");
                this.SetStatusFormStepIt();
              
            }
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
            this.HideStatusForm();
        }
    }
}
