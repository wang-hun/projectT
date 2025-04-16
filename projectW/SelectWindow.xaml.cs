using AduSkin.Controls.Metro;
using System;
using System.Windows;

namespace projectW
{
    /// <summary>
    /// SelectWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SelectWindow : MetroWindow
    {
        public App app { get; set; }
        private bool flag { get; set; }
        public SelectWindow()
        {
            InitializeComponent();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            if (!flag)
            {
                app.flag= true;
                App.CloseApplication();
               
            }
            flag = false;
        }

        private void MetroButton_Click(object sender, RoutedEventArgs e)
        {
            app.pageIndex = 1;
            flag = true;
            this.Close();


        }
        private void MetroButton_Click2(object sender, RoutedEventArgs e)
        {
            app.pageIndex = 2;
            flag = true;
            this.Close();
        }
    }
}
