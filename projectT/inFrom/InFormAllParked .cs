using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using projectT.MyDialog;
using ProjectT;
using Sunny.UI;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectT
{
    public partial class InFormAllParked : UIPage
    {
        private DataSet ds { get; set; }
        private DataSet allDataSet { get; set; }
        /// <summary>
        /// 是否管理员，可阅览所有数据
        /// </summary>

        public InFormAllParked()
        {
            InitializeComponent();
            BlockchainManager.startBlockChain("/BlockChain");

        }

        public void TableRenew()
        {
            allDataSet = SQLClass.GetDataSet(
             "SELECT LicNumber AS '车牌号', StartParkTime AS '停放时间', EndParkTime AS '开出时间', ParkLocal " +
             "FROM carpark"
             );
            ds = new DataSet();
            DataTable originalTable = allDataSet.Tables[0]; // 假设查询结果在第一个DataTable

            // 克隆结构并移除列
            DataTable newTable = originalTable.Clone();
            newTable.Columns.Remove("ParkLocal");

            // 复制数据
            foreach (DataRow row in originalTable.Rows)
            {
                newTable.ImportRow(row);
            }

            ds.Tables.Add(newTable);


        }
        public void TableReDraw()
        {

            uiDataGridView1.DataSource = ds.Tables[0];
            uiDataGridView1.Refresh();

        }

        public void Renew()
        {
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
            TableReDraw();

        }
        public UIAvatar ThisAvatar()
        {
            return this.uiAvatar1;
        }

        private void InFormMyCar_Initialize(object sender, EventArgs e)
        {

        }

     
        private void reFlashButton_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() => this.TableRenew());
            var th = new Task(() =>
             {

                 this.ShowStatusForm(100, "数据加载中......", 0);
                 for (int i = 0; i < 90; i += 5)
                 {
                     SystemEx.Delay(100);
                     this.SetStatusFormDescription("数据加载中(" + i + "%)......");
                     this.SetStatusFormStepIt(5);
                     if (i > 5 && task.IsCompleted)
                     {
                         this.SetStatusFormDescription("数据加载中(" + 100 + "%)......");
                         this.SetStatusFormStepIt(100);
                         this.ShowInfoDialog("数据读取完成");

                         return;
                     }

                 }
                 while (!task.IsCompleted)
                 {
                     SystemEx.Delay(100);
                 }
                 this.ShowInfoDialog("数据读取完成");
             });
            th.Start();
            TableReDraw();

        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];

                // 获取第一列的值（根据实际情况调整列索引）
                string carNumber = selectedRow.Cells[0].Value.ToString();
                DateTime parkTime = (DateTime)selectedRow.Cells[1].Value;
                DateTime parkEndTime = (DateTime)selectedRow.Cells[2].Value;
                ///todo:生成一个显示位置的弹窗
                string filter = $"[车牌号] = '{carNumber.Replace("'", "''")}' " +
                    $"AND [停放时间] = #{parkTime:yyyy-MM-dd HH:mm:ss}# " +
                    $"AND [开出时间] = #{parkEndTime:yyyy-MM-dd HH:mm:ss}#";

                // 从原始数据集查询
                DataRow[] matchingRows = allDataSet.Tables[0].Select(filter);
                string hashValue = matchingRows[0]["ParkLocal"].ToString();
               
                ///TODO 新建一个显示地图位置的窗体
                var locals = BlockchainManager.QueryBlockByHash(hashValue);
                if (locals.isValid == true)
                {
                    using (var newWIndows = new WhereMyCar(carNumber, locals.local, parkTime, parkEndTime))
                    {

                        newWIndows.ShowDialog();

                    }
                }
            }
            else
            {

                this.ShowErrorTip("请在表格中选中一行，你要查询的停车场。");
            }
        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];
                string parkID = selectedRow.Cells[0].Value.ToString();
                var user = SQLClass.ExecuteReader("SELECT u.name AS 用户姓名" +
                   ", u.telnum AS 用户电话 " +
                   "FROM park p JOIN users u ON p.manageID = u.user " +
                   "WHERE  p.parkID = " + parkID + "; ");
                if (user.Read())
                {
                    var name = user.GetString("用户姓名");
                    var telnumber = user.GetString("用户电话");
                    this.ShowInfoDialog("联系方式", "管理员:\t" + name + "\n\r 联系电话:\t" + telnumber);
                }

            }
            else
            {

                this.ShowErrorTip("请在表格中选中一行，你要查询的停车场。");
            }
        }
    }
}

