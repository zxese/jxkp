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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string MyBgPhoto;
        private string MyAddress;
        private string MyTel;
        private string MyCode;
        private string MyWeb;
        private string MySlogan;
        private string MyBgPhotoShow;
        private string MyOperator;
        private string MyCompany;
        private void MainForm_Load(object sender, EventArgs e)
        {
            //添加ThreadException事件关联程序
            Application.ThreadException += MyThreadException;
            
            //从公司信息数据表中读取基本信息
            //this.GetCompanyInformation();
           
            //显示登录对话框
            LoginForm MyDlg = new LoginForm();
            
            //MyDlg.Text = "欢迎使用" + MySlogan;
            
            MyDlg.ShowDialog(this);
            this.MyOperator = MyDlg.用户名称TextBox.Text;
            //根据用户的操作权限配置系统菜单
            SetUserOperateMenu();
            
            //最大化显示系统主窗体
            if (MyOperator.Length > 0)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            
            //设置系统背景图像信息
            //this.BackgroundImage = new Bitmap(this.MyBgPhotoShow, true);
            
            //设置系统标题栏显示文字
            //this.Text = MySlogan;
        }
        
        //系统异常处理代码
        public void MyThreadException(Object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string MyInfo = "错误名称：" + e.Exception.Source + "，错误信息：" + e.Exception.Message;
            MessageBox.Show(MyInfo, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        //实现在系统关闭前给予用户提示
        protected override void WndProc(ref Message SystemMessage)
        {
            switch (SystemMessage.Msg)
            {
                case 0x0112:
                    if (((int)SystemMessage.WParam) == 61536)
                    {
                        退出系统EToolStripMenuItem_Click(null, null);
                    }
                    else
                    {
                        base.WndProc(ref SystemMessage);
                    }
                    break;
                default:
                    base.WndProc(ref SystemMessage);
                    break;
            }
        }

        
        //根据用户的操作权限配置系统菜单
        public void SetUserOperateMenu()
        {
            String MySQLConnectionString = global::绩效考评系统.Properties.Settings.Default.绩效考评系统ConnectionString;
            string MySQL = "Select  *  From 操作用户 Where 用户名称='" + this.MyOperator + "'";
            SqlConnection MyConnection = new SqlConnection(MySQLConnectionString);
            MyConnection.Open();
            DataTable MyTable = new DataTable();
            SqlDataAdapter MyAdapter = new SqlDataAdapter(MySQL, MyConnection);
            MyAdapter.Fill(MyTable);

            if ((int)MyTable.Rows[0]["人事管理之基本档案"] == 0)
            {
                this.基本档案ToolStripMenuItem.Visible = false;
                this.基本档案ToolStripSeparator.Visible = false;
                this.基本档案ToolStripButton.Visible = false;
            }
            
            if ((int)MyTable.Rows[0]["系统管理之操作权限设置"] == 0)
            {
                this.操作权限设置ToolStripMenuItem.Visible = false;
                this.操作权限设置ToolStripSeparator.Visible = false;
            }
            if ((int)MyTable.Rows[0]["系统管理之修改用户密码"] == 0)
            {
                this.修改用户密码ToolStripMenuItem.Visible = false;
                this.修改用户密码ToolStripSeparator.Visible = false;
            }
           
            if ((int)MyTable.Rows[0]["系统管理之公司部门设置"] == 0)
            {
                this.公司部门设置ToolStripMenuItem.Visible = false;
                this.公司部门设置ToolStripSeparator.Visible = false;
            }
            if (MyConnection.State == ConnectionState.Open)
            {
                MyConnection.Close();
            }
        }
        private void 退出系统EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定现在退出本系统吗？", "信息提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
       

        private void 公司部门设置DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentForm MyDlg = new DepartmentForm();
            MyDlg.ShowDialog();
        }

        private void 基本档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonnelForm MyDlg = new PersonnelForm();
            MyDlg.ShowDialog();
        }


        private void 操作权限设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorForm MyDlg = new OperatorForm();
            MyDlg.ShowDialog();
        }

        private void 修改用户密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserPasswordForm MyDlg = new ChangeUserPasswordForm();
            MyDlg.用户名称TextBox.Text = this.MyOperator;
            MyDlg.ShowDialog();
        }

        
    }
}