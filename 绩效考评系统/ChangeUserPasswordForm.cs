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
    public partial class ChangeUserPasswordForm : Form
    {
        public ChangeUserPasswordForm()
        {
            InitializeComponent();
        }

        private void 修改密码Button_Click(object sender, EventArgs e)
        {
            if (!(this.新密码TextBox.Text == this.再输一次新密码TextBox.Text) || (this.新密码TextBox.Text.Length == 0))
            {
                MessageBox.Show("两次密码的输入不一致！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            String MySQLConnectionString = global::绩效考评系统.Properties.Settings.Default.绩效考评系统ConnectionString;
            string MySQL = "Update  操作用户 Set 用户密码='" + this.新密码TextBox.Text + "' Where 用户名称='" + this.用户名称TextBox.Text + "' AND 用户密码='" + this.旧密码TextBox.Text + "'";
            SqlConnection MyConnection = new SqlConnection(MySQLConnectionString);
            SqlCommand MyCommand = new SqlCommand(MySQL, MyConnection);
            MyCommand.Connection.Open();
            int MyCount = MyCommand.ExecuteNonQuery();
            if (MyCount == 1)
            {
                MessageBox.Show("在数据库中修改用户密码操作成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("在数据库中修改用户密码操作失败！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (MyConnection.State == ConnectionState.Open)
            {
                MyConnection.Close();
            }
        }

        private void 返回系统Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}