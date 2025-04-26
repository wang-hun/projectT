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
using ProjectT;
using Sunny.UI;

namespace projectT
{
    public partial class InFormMyCar : UIPage
    {
        private List<string> carnumbers = new List<string>();
        public InFormMyCar()
        {
            InitializeComponent();
        }
        public void TableRenew()
        {
            DataSet ds = SQLClass.GetDataSet("select CarID,CarType,CarNumber from cars where userid=" + "\"" + PublicClass.userObject.Username + "\"");
            uiDataGridView1.DataSource = ds.Tables[0];
            carnumbers.Clear();
            carnumbers.AddRange(ds.Tables[0].AsEnumerable()
           .Select(row => row.Field<string>("CarNumber"))
           .Where(carNumber => carNumber != null)
   );
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
            TableRenew();
            BlockchainManager.startBlockChain("\\BlockChain");
        }
        private void InFormMyCar_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            Renew();
            Image originalImage = uiImageButton1.Image;
            uiImageButton1.ImagePress = PublicClass.AdjustBrightness(originalImage, -0.2f); // 调整亮度为更暗
            uiImageButton1.ImageHover = PublicClass.AdjustBrightness(originalImage, 0.4f); // 调整亮度为更亮
            originalImage = uiImageButton2.Image;
            uiImageButton2.ImagePress = PublicClass.AdjustBrightness(originalImage, -0.2f); // 调整亮度为更暗
            uiImageButton2.ImageHover = PublicClass.AdjustBrightness(originalImage, 0.4f); // 调整亮度为更亮
        }
        public UIAvatar ThisAvatar()
        {
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
                string cNumer = selectedRow.Cells[2].Value.ToString();
                if (this.ShowAskDialog("提示", "你确定删除" + cNumer + "的车辆信息吗？"))
                {
                    SQLClass.ExecuteSql("DELETE FROM cars WHERE CarID =\"" + selectedRow.Cells[0].Value.ToString() + "\"");
                    uiDataGridView1.Rows.Remove(selectedRow);

                }
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            string str = null;
            this.ShowInfoDialog("提示", "请上传车牌照片。");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // 设置文件筛选器
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            // 显示对话框
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取到用户选择的图片文件路径
                string imagePath = openFileDialog.FileName;
                str = CarIdentity.getNumber(imagePath);
            }
            else
            {
                return;
            }
            var carNumbers = new List<string>();
            using (MySqlDataReader reader = SQLClass.ExecuteReader("SELECT CarNumber FROM cars"))
            {
                while (reader.Read())
                {
                    carNumbers.Add(reader.GetString(0));
                }
            }
            if (carNumbers.Contains(str))
            {
                this.ShowErrorDialog("错误！", "该车辆已被其他人添加！");
                return;
            }
            if (str != null)
            {
                string value = "请输入字符串";
                if (this.ShowInputStringDialog(ref value, true, "请输入车辆描述：", true))
                {
                    MySqlDataReader ds = SQLClass.ExecuteReader("select * from cars ORDER BY CarID DESC LIMIT 1");
                    ds.Read();
                    int carIDI = ds.GetInt32("CarID") + 1;
                    SQLClass.ExecuteSql("INSERT INTO cars(CarType,CarID,CarNumber,userid )VALUES(\"" + value + "\",\"" + carIDI + "\",\"" + str + "\",\"" + PublicClass.userObject.Username + "\")");
                    this.TableRenew();
                }

            }
            else
            {
                this.ShowErrorDialog("错误！", "图像识别失败或者网络访问错误！");
            }
        }

        private void uiImageButton3_Click(object sender, EventArgs e)
        {
            Renew();
        }

        private void uiImageButton4_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = uiDataGridView1.SelectedRows[0];

                // 获取第一列的值（根据实际情况调整列索引）
                string cNumer = selectedRow.Cells[2].Value.ToString();
                FindCar(cNumer);
            }
            else
            {

                this.ShowErrorTip("请在表格中选中一行，你要查询的车辆。");
            }

        }
        private void FindCar(string cNumber)
        {
            var dr = SQLClass.ExecuteReader("select * from nowpark where carNumber='" + cNumber + "'");
            if (dr.Read())
            {
                string carNumber = dr["carNumber"].ToString();
                DateTime parkTime = Convert.ToDateTime(dr["parkStartTime"]);
                string hashValue = dr["local"].ToString();
                ///TODO 新建一个显示地图位置的窗体
            }
            else 
            {
                this.ShowInfoTip("该车目前未停在任何停车场。");
            }
        }
    }
}
