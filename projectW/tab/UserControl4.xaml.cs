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
    /// UserControl4.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }
        public static readonly RoutedEvent CustomButtonClickEvent = EventManager.RegisterRoutedEvent(
    "CustomButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(UserControl4));

        public event RoutedEventHandler CustomButtonClick
        {
            add { AddHandler(CustomButtonClickEvent, value); }
            remove { RemoveHandler(CustomButtonClickEvent, value); }
        }


        private void MetroButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(CustomButtonClickEvent));
        }
    }
}
