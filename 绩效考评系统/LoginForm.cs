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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        //记录用户登录次数
        private int MyTryCount = 0;

        private void 登录系统Button_Click(object sender, EventArgs e)
        {
            //从app.config文件中读取数据库连接字符串信息
            String MySQLConnectionString = global::绩效考评系统.Properties.Settings.Default.绩效考评系统ConnectionString;
            string MySQL = "Select COUNT(*) From 操作用户 Where 用户名称=@用户名称 AND 用户密码=@用户密码";
            SqlConnection MyConnection = new SqlConnection(MySQLConnectionString);
            MyConnection.Open();
            SqlCommand MyCommand = new SqlCommand(MySQL, MyConnection);
            MyCommand.Parameters.Clear();
            SqlParameter MySqlNameParameter = new SqlParameter();
            MySqlNameParameter.ParameterName = "@用户名称";
            MySqlNameParameter.Value = this.用户名称TextBox.Text;
            MyCommand.Parameters.Add(MySqlNameParameter);
            SqlParameter MySqlPWParameter = new SqlParameter();
            MySqlPWParameter.ParameterName = "@用户密码";
            MySqlPWParameter.Value = this.用户密码TextBox.Text;
            MyCommand.Parameters.Add(MySqlPWParameter);
            int MyCount = (int)MyCommand.ExecuteScalar();
            if (MyCount == 1)
            {
                this.Close();
            }
            else
            {
  	        this.MyTryCount += 1;
                if (this.MyTryCount != 3)
                {
                    int MyDoCount = 3 - this.MyTryCount;
                    MessageBox.Show("用户密码或用户名称有错，还有" + MyDoCount + "次机会！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.用户密码TextBox.Text = "";
                    this.用户名称TextBox.Text = "";                    
                }
                else
                {
                    退出系统Button_Click(null, null);
                }
            }
            if (MyConnection.State == ConnectionState.Open)
            {
                MyConnection.Close();
            }
        }

        private void 退出系统Button_Click(object sender, EventArgs e)
        {
            MainForm MyDlg = (MainForm)this.Owner;
            MyDlg.Close();
        }
    }
}