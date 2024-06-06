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
    public partial class InFormMyCar : UIPage
    {
        public InFormMyCar()
        {
            InitializeComponent();
        }
        public void TableRenew() {
          DataSet ds=SQLClass.GetDataSet("select CarID,CarType,CarNumber from cars where userid="+"\""+PublicClass.userObject.Username+ "\"");
          uiDataGridView1.DataSource=ds.Tables[0];
          
        }
        public void Renew() {
            uiLabel2.Text = PublicClass.userObject.Name;
            uiLabel1.Text = PublicClass.userObject.Username;
            
            if (PublicClass.userObject.QqID == null || PublicClass.userObject.QqID.Equals(String.Empty))
                this.uiAvatar1.Image = projectT.Properties.Resources.TT;
            else
            {
                PublicClass.LoadImageFromUrl(this.uiAvatar1, "http://q1.qlogo.cn/g?b=qq&nk=" + PublicClass.userObject.QqID + "&s=640");
            }
        }
        private void InFormMyCar_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            Renew();
            TableRenew();
        }
        public UIAvatar ThisAvatar() {
            return this.uiAvatar1;
        }

        private void InFormMyCar_Initialize(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];

                // 获取第一列的值（根据实际情况调整列索引）
                string cNumer = selectedRow.Cells[1].Value.ToString();
                if (this.ShowAskDialog("提示", "你确定删除" + cNumer + "的车辆信息吗？")) {
                    SQLClass.ExecuteSql("DELETE FROM cars WHERE CarID =\"" + selectedRow.Cells[0].Value.ToString() + "\"");
                    uiDataGridView1.Rows.Remove(selectedRow);
                  
                }
            }
            }
    }
}
