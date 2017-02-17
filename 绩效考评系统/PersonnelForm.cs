//文件名：PersonnelForm.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace 绩效考评系统
{
    public partial class PersonnelForm : Form
    {
        public PersonnelForm()
        {
            InitializeComponent();
        }

        private void 基本档案BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.基本档案BindingSource.EndEdit();
            this.基本档案TableAdapter.Update(this.myPersonnelDataSet.基本档案);

        }

        private void PersonnelForm_Load(object sender, EventArgs e)
        {         
            //获取公司的部门信息            
            String MySQLConnectionString = global::绩效考评系统.Properties.Settings.Default.绩效考评系统ConnectionString;
            SqlConnection MyConnection = new SqlConnection(MySQLConnectionString);
            MyConnection.Open();
            DataTable MyDepartmentTable = new DataTable();
            string MySQL = "Select * From 公司部门";
            SqlDataAdapter MyAdapter = new SqlDataAdapter(MySQL, MyConnection);
            MyAdapter.Fill(MyDepartmentTable);
            this.部门ComboBox.DataSource = MyDepartmentTable;
            this.部门ComboBox.DisplayMember = "部门名称";
            this.部门ComboBox.ValueMember = "部门名称";
            if (MyConnection.State == ConnectionState.Open)
            {
                MyConnection.Close();
            }
            // TODO: 这行代码将数据加载到表“myPersonnelDataSet.基本档案”中。您可以根据需要移动或移除它。
            this.基本档案TableAdapter.Fill(this.myPersonnelDataSet.基本档案);
            this.myPersonnelDataSet.基本档案.Rows.Clear();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //自动计算基本档案自编号
            String MySQLConnectionString = global::绩效考评系统.Properties.Settings.Default.绩效考评系统ConnectionString;
            SqlConnection MyConnection = new SqlConnection(MySQLConnectionString);
            MyConnection.Open();
            SqlCommand MyCommand = MyConnection.CreateCommand();
            MyCommand.CommandText = "Select max(自编号) 最大编号 From 基本档案";
            object MyResult = MyCommand.ExecuteScalar();
            Int64 MyID = 1;
            if (MyResult != System.DBNull.Value)
            {
                String MyMaxID = MyResult.ToString().Trim();
                MyMaxID = MyMaxID.Substring(2, MyMaxID.Length - 2);
                MyID = Convert.ToInt64(MyMaxID) + 1;
            }
            int MyLength = MyID.ToString().Length;
            string MyNewID = "";
            switch (MyLength)
            {
                case 1:
                    MyNewID = "DA0000000" + MyID.ToString();
                    break;
                case 2:
                    MyNewID = "DA000000" + MyID.ToString();
                    break;
                case 3:
                    MyNewID = "DA00000" + MyID.ToString();
                    break;
                case 4:
                    MyNewID = "DA0000" + MyID.ToString();
                    break;
                case 5:
                    MyNewID = "DA000" + MyID.ToString();
                    break;
                case 6:
                    MyNewID = "DA00" + MyID.ToString();
                    break;
                case 7:
                    MyNewID = "DA0" + MyID.ToString();
                    break;
            }
            if (MyConnection.State == ConnectionState.Open)
            {
                MyConnection.Close();
            }
            this.自编号TextBox.Text = MyNewID;          
        }
        private void 查询FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.基本档案TableAdapter.FillBy(this.myPersonnelDataSet.基本档案, 姓名ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    
    }
}