namespace cs_taptapheros
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView_heros = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_filter_camp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox_filter_major = new System.Windows.Forms.ComboBox();
            this.comboBox_filter_stars = new System.Windows.Forms.ComboBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1043, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView_heros);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1035, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "英雄图鉴";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView_heros
            // 
            this.listView_heros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_heros.FullRowSelect = true;
            this.listView_heros.HideSelection = false;
            this.listView_heros.Location = new System.Drawing.Point(8, 149);
            this.listView_heros.MultiSelect = false;
            this.listView_heros.Name = "listView_heros";
            this.listView_heros.Size = new System.Drawing.Size(322, 533);
            this.listView_heros.TabIndex = 1;
            this.listView_heros.UseCompatibleStateImageBehavior = false;
            this.listView_heros.View = System.Windows.Forms.View.Details;
            this.listView_heros.SelectedIndexChanged += new System.EventHandler(this.listView_heros_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "阵营";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "职业";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "星级";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "最高等级";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_filter_stars);
            this.groupBox1.Controls.Add(this.comboBox_filter_major);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_filter_camp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "过滤器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "星级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "职业";
            // 
            // comboBox_filter_camp
            // 
            this.comboBox_filter_camp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_camp.FormattingEnabled = true;
            this.comboBox_filter_camp.Items.AddRange(new object[] {
            "all",
            "联盟(蓝)",
            "部落(红)",
            "精灵(紫)",
            "不死(绿)",
            "天堂(金)",
            "地狱(黑红)"});
            this.comboBox_filter_camp.Location = new System.Drawing.Point(63, 29);
            this.comboBox_filter_camp.Name = "comboBox_filter_camp";
            this.comboBox_filter_camp.Size = new System.Drawing.Size(121, 20);
            this.comboBox_filter_camp.TabIndex = 1;
            this.comboBox_filter_camp.SelectedIndexChanged += new System.EventHandler(this.comboBox_filter_camp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "阵营";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1035, 690);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "合成公式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox_filter_major
            // 
            this.comboBox_filter_major.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_major.FormattingEnabled = true;
            this.comboBox_filter_major.Items.AddRange(new object[] {
            "all",
            "刺客",
            "战士",
            "法师",
            "牧师",
            "游侠"});
            this.comboBox_filter_major.Location = new System.Drawing.Point(63, 61);
            this.comboBox_filter_major.Name = "comboBox_filter_major";
            this.comboBox_filter_major.Size = new System.Drawing.Size(121, 20);
            this.comboBox_filter_major.TabIndex = 5;
            this.comboBox_filter_major.SelectedIndexChanged += new System.EventHandler(this.comboBox_filter_major_SelectedIndexChanged);
            // 
            // comboBox_filter_stars
            // 
            this.comboBox_filter_stars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_stars.FormattingEnabled = true;
            this.comboBox_filter_stars.Items.AddRange(new object[] {
            "all",
            "1星",
            "2星",
            "3星",
            "4星",
            "5星",
            "10星",
            "15星"});
            this.comboBox_filter_stars.Location = new System.Drawing.Point(63, 94);
            this.comboBox_filter_stars.Name = "comboBox_filter_stars";
            this.comboBox_filter_stars.Size = new System.Drawing.Size(121, 20);
            this.comboBox_filter_stars.TabIndex = 6;
            this.comboBox_filter_stars.SelectedIndexChanged += new System.EventHandler(this.comboBox_filter_stars_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "名字";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 716);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Taptap Heros Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_heros;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_filter_camp;
        private System.Windows.Forms.ComboBox comboBox_filter_stars;
        private System.Windows.Forms.ComboBox comboBox_filter_major;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

