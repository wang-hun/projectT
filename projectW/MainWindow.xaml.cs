using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
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
using AduSkin.Controls.Metro;


namespace projectW
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
       
        public ObservableCollection<string> StepItems { get; set; }
        public int StepIndex { get; set; }
        public MainWindow()
        {
           
            InitializeComponent();
            this.DataContext = this;
            StepItems=new ObservableCollection<string>();
            StepItems.Add("第一步");
            StepItems.Add("第二步");
            StepItems.Add("第三步");
            StepItems.Add("第四步");
        }
    }
}
