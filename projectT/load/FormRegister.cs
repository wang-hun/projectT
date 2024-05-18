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
    public partial class FormRegister : UIForm
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (this.ShowAskDialog("提示", "确定要退出吗？将不会保留您填写的信息。",UIStyle.Red)) {
                this.DialogResult = DialogResult.No;
                this.Close();
            };
        }
    }
}
