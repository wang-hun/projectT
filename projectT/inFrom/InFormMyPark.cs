using MySql.Data.MySqlClient;
using projectT.MyDialog;
using Sunny.UI;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GMap.NET.Entity.OpenStreetMapGraphHopperGeocodeEntity;

namespace projectT
{
    public partial class InFormMyPark : UIPage
    {
        private DataSet ds { get; set; }
        public InFormMyPark()
        {
            InitializeComponent();

        }
        public void TableRenew()
        {
            ds = SQLClass.GetDataSet
                (
                "select " +
                "parkID,location,maxParking,nowParking," +
                "CASE WHEN opening = 1 " +
                "THEN '开放' WHEN opening = 0 " +
                "THEN '关闭' " +
                "END AS opening " +
                "from park " +
                "where manageID=" + "\"" + PublicClass.userObject.Username + "\""
                );

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

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {//删除停车场操作
            //需要判断停车场是否打开，是否仍有车辆在内
            if (uiDataGridView1.SelectedRows.Count > 0)
            {



                DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];

                // 获取第一列的值（根据实际情况调整列索引）
                string cNumer = selectedRow.Cells[1].Value.ToString();
                //
                if (Convert.ToInt32(selectedRow.Cells[3].Value.ToString()) == 0)
                {
                    if (selectedRow.Cells[4].Value.ToString().Equals("False"))
                    {
                        if (this.ShowAskDialog("提示", "你确定删除" + cNumer + "的停车场信息吗？"))
                        {
                            SQLClass.ExecuteSql("DELETE FROM park WHERE parkID =\"" + selectedRow.Cells[0].Value.ToString() + "\"");
                            uiDataGridView1.Rows.Remove(selectedRow);

                        }
                    }
                    else
                    {
                        this.ShowErrorDialog("此停车场处于开放状态，不可删除！请关闭停车场。");
                    }
                }
                else
                {
                    this.ShowErrorTip("此停车场还存在在停车辆，不能删除！");
                }
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {

            AddParkInfo frm = new AddParkInfo();

            frm.Render();
            frm.ShowDialog();
            if (frm.IsOK)
            {
                AddParkLocation fr = new AddParkLocation();

                fr.Render();
                fr.ShowDialog();
                if (fr.IsOK && AddParkLocation.ischeck)
                {
                    MySqlDataReader ds = SQLClass.ExecuteReader("select * from park ORDER BY parkID DESC LIMIT 1");
                    ds.Read();
                    int parkIDI = ds.GetInt32("parkID") + 1;
                    SQLClass.ExecuteSql("INSERT INTO park(parkID,location,maxParking,nowParking,manageID,opening,PosX,PosY)VALUES(" + parkIDI + ",\"" + AddParkInfo.location + "\"," + AddParkInfo.parkMaxNum + "," + 0 + ",\"" + PublicClass.userObject.Username + "\",0," + AddParkLocation.PosX + "," + AddParkLocation.PosY + ")");
                    this.TableRenew();
                    TableReDraw();
                }
                frm.Dispose();


            }
            frm.Dispose();
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];

            // 获取第一列的值（根据实际情况调整列索引）
            string opening = selectedRow.Cells[4].Value.ToString();
            if (opening.Equals("开放"))
            {
                SQLClass.ExecuteSql(" UPDATE park SET opening = 0 WHERE parkID = " + selectedRow.Cells[0].Value);
            }
            else
            {
                SQLClass.ExecuteSql(" UPDATE park SET opening = 1 WHERE parkID = " + selectedRow.Cells[0].Value);
            }
            this.TableRenew();
            TableReDraw();
        }

        private void reFlashButton_Click(object sender, EventArgs e)
        {
            Task task=Task.Run(() => this.TableRenew());
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
    }
}

