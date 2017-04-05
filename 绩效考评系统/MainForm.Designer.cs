namespace 绩效考评系统
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.人事管理PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本档案ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.绩效考评ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作权限设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作权限设置ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.修改用户密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改用户密码ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.公司部门设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公司部门设置ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.系统帮助信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.基本档案ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.工资信息ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.退出系统ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人事管理PToolStripMenuItem,
            this.系统管理SToolStripMenuItem,
            this.退出系统EToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 人事管理PToolStripMenuItem
            // 
            this.人事管理PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本档案ToolStripMenuItem,
            this.基本档案ToolStripSeparator,
            this.绩效考评ToolStripMenuItem});
            this.人事管理PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("人事管理PToolStripMenuItem.Image")));
            this.人事管理PToolStripMenuItem.Name = "人事管理PToolStripMenuItem";
            this.人事管理PToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.人事管理PToolStripMenuItem.Text = "考评管理(&P)";
            // 
            // 基本档案ToolStripMenuItem
            // 
            this.基本档案ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("基本档案ToolStripMenuItem.Image")));
            this.基本档案ToolStripMenuItem.Name = "基本档案ToolStripMenuItem";
            this.基本档案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.基本档案ToolStripMenuItem.Text = "员工档案(&D)";
            this.基本档案ToolStripMenuItem.Click += new System.EventHandler(this.基本档案ToolStripMenuItem_Click);
            // 
            // 基本档案ToolStripSeparator
            // 
            this.基本档案ToolStripSeparator.Name = "基本档案ToolStripSeparator";
            this.基本档案ToolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // 绩效考评ToolStripMenuItem
            // 
            this.绩效考评ToolStripMenuItem.Name = "绩效考评ToolStripMenuItem";
            this.绩效考评ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.绩效考评ToolStripMenuItem.Text = "绩效考评(&K)";
            this.绩效考评ToolStripMenuItem.Click += new System.EventHandler(this.绩效考评ToolStripMenuItem_Click);
            // 
            // 系统管理SToolStripMenuItem
            // 
            this.系统管理SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作权限设置ToolStripMenuItem,
            this.操作权限设置ToolStripSeparator,
            this.修改用户密码ToolStripMenuItem,
            this.修改用户密码ToolStripSeparator,
            this.公司部门设置ToolStripMenuItem,
            this.公司部门设置ToolStripSeparator,
            this.系统帮助信息ToolStripMenuItem});
            this.系统管理SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("系统管理SToolStripMenuItem.Image")));
            this.系统管理SToolStripMenuItem.Name = "系统管理SToolStripMenuItem";
            this.系统管理SToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.系统管理SToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // 操作权限设置ToolStripMenuItem
            // 
            this.操作权限设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("操作权限设置ToolStripMenuItem.Image")));
            this.操作权限设置ToolStripMenuItem.Name = "操作权限设置ToolStripMenuItem";
            this.操作权限设置ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.操作权限设置ToolStripMenuItem.Text = "操作权限设置(&O)";
            this.操作权限设置ToolStripMenuItem.Click += new System.EventHandler(this.操作权限设置ToolStripMenuItem_Click);
            // 
            // 操作权限设置ToolStripSeparator
            // 
            this.操作权限设置ToolStripSeparator.Name = "操作权限设置ToolStripSeparator";
            this.操作权限设置ToolStripSeparator.Size = new System.Drawing.Size(163, 6);
            // 
            // 修改用户密码ToolStripMenuItem
            // 
            this.修改用户密码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改用户密码ToolStripMenuItem.Image")));
            this.修改用户密码ToolStripMenuItem.Name = "修改用户密码ToolStripMenuItem";
            this.修改用户密码ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.修改用户密码ToolStripMenuItem.Text = "修改用户密码(&P)";
            this.修改用户密码ToolStripMenuItem.Click += new System.EventHandler(this.修改用户密码ToolStripMenuItem_Click);
            // 
            // 修改用户密码ToolStripSeparator
            // 
            this.修改用户密码ToolStripSeparator.Name = "修改用户密码ToolStripSeparator";
            this.修改用户密码ToolStripSeparator.Size = new System.Drawing.Size(163, 6);
            // 
            // 公司部门设置ToolStripMenuItem
            // 
            this.公司部门设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("公司部门设置ToolStripMenuItem.Image")));
            this.公司部门设置ToolStripMenuItem.Name = "公司部门设置ToolStripMenuItem";
            this.公司部门设置ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.公司部门设置ToolStripMenuItem.Text = "公司部门设置(&D)";
            this.公司部门设置ToolStripMenuItem.Click += new System.EventHandler(this.公司部门设置DToolStripMenuItem_Click);
            // 
            // 公司部门设置ToolStripSeparator
            // 
            this.公司部门设置ToolStripSeparator.Name = "公司部门设置ToolStripSeparator";
            this.公司部门设置ToolStripSeparator.Size = new System.Drawing.Size(163, 6);
            // 
            // 系统帮助信息ToolStripMenuItem
            // 
            this.系统帮助信息ToolStripMenuItem.Name = "系统帮助信息ToolStripMenuItem";
            this.系统帮助信息ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.系统帮助信息ToolStripMenuItem.Text = "系统帮助信息(&H)";
            this.系统帮助信息ToolStripMenuItem.Click += new System.EventHandler(this.系统帮助信息ToolStripMenuItem_Click);
            // 
            // 退出系统EToolStripMenuItem
            // 
            this.退出系统EToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出系统EToolStripMenuItem.Image")));
            this.退出系统EToolStripMenuItem.Name = "退出系统EToolStripMenuItem";
            this.退出系统EToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.退出系统EToolStripMenuItem.Text = "退出系统(&E)";
            this.退出系统EToolStripMenuItem.Click += new System.EventHandler(this.退出系统EToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本档案ToolStripButton,
            this.工资信息ToolStripButton,
            this.退出系统ToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(542, 56);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            // 
            // 基本档案ToolStripButton
            // 
            this.基本档案ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("基本档案ToolStripButton.Image")));
            this.基本档案ToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.基本档案ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.基本档案ToolStripButton.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.基本档案ToolStripButton.Name = "基本档案ToolStripButton";
            this.基本档案ToolStripButton.Size = new System.Drawing.Size(60, 53);
            this.基本档案ToolStripButton.Text = "基本档案";
            this.基本档案ToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.基本档案ToolStripButton.Click += new System.EventHandler(this.基本档案ToolStripMenuItem_Click);
            // 
            // 工资信息ToolStripButton
            // 
            this.工资信息ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("工资信息ToolStripButton.Image")));
            this.工资信息ToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.工资信息ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.工资信息ToolStripButton.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.工资信息ToolStripButton.Name = "工资信息ToolStripButton";
            this.工资信息ToolStripButton.Size = new System.Drawing.Size(60, 53);
            this.工资信息ToolStripButton.Text = "工资信息";
            this.工资信息ToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // 退出系统ToolStripButton
            // 
            this.退出系统ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("退出系统ToolStripButton.Image")));
            this.退出系统ToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.退出系统ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.退出系统ToolStripButton.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.退出系统ToolStripButton.Name = "退出系统ToolStripButton";
            this.退出系统ToolStripButton.Size = new System.Drawing.Size(60, 53);
            this.退出系统ToolStripButton.Text = "退出系统";
            this.退出系统ToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.退出系统ToolStripButton.Click += new System.EventHandler(this.退出系统EToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 416);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "绩效考评管理系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 退出系统EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事管理PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 基本档案ToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 系统管理SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作权限设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 操作权限设置ToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 修改用户密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 修改用户密码ToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 公司部门设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator 公司部门设置ToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 系统帮助信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 基本档案ToolStripButton;
        private System.Windows.Forms.ToolStripButton 工资信息ToolStripButton;
        private System.Windows.Forms.ToolStripButton 退出系统ToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 绩效考评ToolStripMenuItem;
    }
}