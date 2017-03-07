using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 绩效考评系统
{
    public partial class DepartmentForm : Form
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void 公司部门BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.公司部门BindingSource.EndEdit();
            this.公司部门TableAdapter.Update(this.myPersonnelDataSet.公司部门);

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“myPersonnelDataSet.公司部门”中。您可以根据需要移动或移除它。
            this.公司部门TableAdapter.Fill(this.myPersonnelDataSet.公司部门);

        }
    }
}