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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projectW.tab
{
    /// <summary>
    /// InTab.xaml 的交互逻辑
    /// </summary>
    public partial class InTab : UserControl
    {
        public InOutWindow father { get; set; }
        public InTab()
        {
            InitializeComponent();
        }
        private void ReNew(object sender, RoutedEventArgs e)
        {
            father.renew();
        }

        private void MetroButton_Click(object sender, RoutedEventArgs e)
        {
            ///生成记录
            if (father.SaveInPark())
            {
               
                father.renew();
            }
        }
    }
}
