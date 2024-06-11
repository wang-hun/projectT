using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projectT.MyDialog;
using Sunny.UI;

namespace projectT
{
    public partial class InFormMyPark: UIPage
    {
        public InFormMyPark()
        {
            InitializeComponent();
        }
        public void TableRenew() {
         DataSet ds=SQLClass.GetDataSet("select parkID,location,maxParking,nowParking,opening from park where manageID="+"\""+PublicClass.userObject.Username+ "\"");
          uiDataGridView1.DataSource=ds.Tables[0];
         //信息加载
          
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
        {//删除停车场操作
            //需要判断停车场是否打开，是否仍有车辆在内
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                
                
                
                DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];

                // 获取第一列的值（根据实际情况调整列索引）
                string cNumer = selectedRow.Cells[1].Value.ToString();
                //
                if (Convert.ToInt32(selectedRow.Cells[3].Value.ToString()) == 0) {
                    if (selectedRow.Cells[4].Value.ToString().Equals("False")) {
                        if (this.ShowAskDialog("提示", "你确定删除" + cNumer + "的停车场信息吗？")) {
                            SQLClass.ExecuteSql("DELETE FROM park WHERE parkID =\"" + selectedRow.Cells[0].Value.ToString() + "\"");
                            uiDataGridView1.Rows.Remove(selectedRow);

                        }
                    }
                    else {
                        this.ShowErrorDialog("此停车场处于开放状态，不可删除！请关闭停车场。");
                    }
                } else {
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
                MySqlDataReader ds = SQLClass.ExecuteReader("select * from park ORDER BY parkID DESC LIMIT 1");
                ds.Read();
                int parkIDI = ds.GetInt32("parkID") + 1;
                SQLClass.ExecuteSql("INSERT INTO park(parkID,location,maxParking,nowParking,manageID,opening)VALUES(" +parkIDI + ",\"" + AddParkInfo.location + "\"," + AddParkInfo.parkMaxNum + "," + 0 +",\""+PublicClass.userObject.Username+"\",0)");
                this.TableRenew();
            }
            frm.Dispose();
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];

            // 获取第一列的值（根据实际情况调整列索引）
            string opening = selectedRow.Cells[4].Value.ToString();
            if (opening.Equals("True")) {
                SQLClass.ExecuteSql(" UPDATE park SET opening = 0 WHERE parkID = " + selectedRow.Cells[0].Value);
            }
            else
            {
                SQLClass.ExecuteSql(" UPDATE park SET opening = 1 WHERE parkID = " + selectedRow.Cells[0].Value);
            }
            this.TableRenew();
        }
    }
    }

