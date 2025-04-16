using AduSkin.Controls.Metro;
using projectW.tab;
using System;
using System.Windows;
using System.Windows.Controls;

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
            tabs[0].DataContext = this;
            tabs[1].DataContext = this;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
          
        }
        private void InButtonClick(object sender, RoutedEventArgs e)
        {
            tab.Content = this.tabs[0];
        }
        private void OutButtonClick(object sender, RoutedEventArgs e)
        {
            tab.Content = this.tabs[1];
        }
       
    }
}
