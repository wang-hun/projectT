using AduSkin.Controls.Metro;
using Org.BouncyCastle.Asn1.X509;
using projectW.tab;
using ProjectW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace projectW
{
    /// <summary>
    /// InOutWindow.xaml 的交互逻辑
    /// </summary>
    public partial class InOutWindow : MetroWindow
    {
        private UserControl[] tabs = {
        new InTab(),
        new OutTab()
        }; 
        public InOutWindow()
        {
            InitializeComponent();
            tab.Content = this.tabs[0];
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            App.CloseApplication();
        }
        private void InButtonClick(object sender, RoutedEventArgs e)
        {
          tab.Content=this.tabs[0];
        }
        private void OutButtonClick(object sender, RoutedEventArgs e)
        {
            tab.Content = this.tabs[1];
        }
    }
}
