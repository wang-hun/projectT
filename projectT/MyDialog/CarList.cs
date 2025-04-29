using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectT.MyDialog
{
    public partial class CarList : UIForm
    {
        private DataSet TableSet {  get; set; }
        private string selectItem {  get; set; }
        public CarList(DataSet dataSet, string str)
        {
            InitializeComponent();
            TableSet=dataSet;
            selectItem=str;
            this.uiDataGridView1.DataSource = TableSet.Tables[0];
            uiDataGridView1.AutoResizeColumns();
            uiSymbolLabel1.Text= str+"查询";
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {
            // 获取搜索关键词（去除首尾空格）
            string searchKey = uiTextBox1.Text.Trim();

            // 获取数据源中的唯一表格
            DataTable originalTable = TableSet.Tables[0];

            // 创建用于绑定的新表格（保持相同结构）
            DataTable filteredTable = originalTable.Clone();

           
                // 构建过滤条件
                string filter = "";
                if (!string.IsNullOrEmpty(searchKey))
                {
                    // 处理特殊字符（防止注入攻击）
                    string safeKey = searchKey.Replace("'", "''");

                    // 构建模糊查询条件
                    filter = $"{selectItem} LIKE '%{safeKey}%'";
                }

                // 获取过滤后的行（空filter时返回所有行）
                DataRow[] rows = originalTable.Select(filter);

                // 将结果复制到新表
                foreach (DataRow row in rows)
                {
                    filteredTable.ImportRow(row);
                }

                // 绑定到DataGridView
                uiDataGridView1.DataSource = filteredTable;

                // 可选：自动调整列宽（如果需要）
                // uiDataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            
          
        }
    }
}
/*
    DataSet ds = SQLClass.GetDataSet("select CarID,CarType,CarNumber from cars where userid=" + "\"" + PublicClass.userObject.Username + "\"");
            uiDataGridView1.DataSource = ds.Tables[0];
 */