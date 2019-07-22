namespace CreateCord
{
    partial class createCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ControllersName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ConpontentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ManagerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelName = new System.Windows.Forms.TextBox();
            this.lABEL = new System.Windows.Forms.Label();
            this.b_choice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.t_path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgridTable = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.表名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.服务名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.查询条件 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JSON值 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnJsonEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridTable)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ControllersName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ConpontentName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ManagerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ModelName);
            this.groupBox1.Controls.Add(this.lABEL);
            this.groupBox1.Controls.Add(this.b_choice);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.t_path);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(179, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "生成策略";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(89, 14);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(100, 21);
            this.fileName.TabIndex = 22;
            this.fileName.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "文件名：";
            // 
            // ControllersName
            // 
            this.ControllersName.Location = new System.Drawing.Point(737, 45);
            this.ControllersName.Name = "ControllersName";
            this.ControllersName.Size = new System.Drawing.Size(100, 21);
            this.ControllersName.TabIndex = 20;
            this.ControllersName.Text = "Controllers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "控制器：";
            // 
            // ConpontentName
            // 
            this.ConpontentName.Location = new System.Drawing.Point(541, 45);
            this.ConpontentName.Name = "ConpontentName";
            this.ConpontentName.Size = new System.Drawing.Size(100, 21);
            this.ConpontentName.TabIndex = 18;
            this.ConpontentName.Text = "BLL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "逻辑层：";
            // 
            // ManagerName
            // 
            this.ManagerName.Location = new System.Drawing.Point(306, 43);
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.Size = new System.Drawing.Size(100, 21);
            this.ManagerName.TabIndex = 16;
            this.ManagerName.Text = "DAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "数据层：";
            // 
            // ModelName
            // 
            this.ModelName.Location = new System.Drawing.Point(89, 42);
            this.ModelName.Name = "ModelName";
            this.ModelName.Size = new System.Drawing.Size(100, 21);
            this.ModelName.TabIndex = 14;
            this.ModelName.Text = "Model";
            // 
            // lABEL
            // 
            this.lABEL.AutoSize = true;
            this.lABEL.Location = new System.Drawing.Point(28, 45);
            this.lABEL.Name = "lABEL";
            this.lABEL.Size = new System.Drawing.Size(53, 12);
            this.lABEL.TabIndex = 13;
            this.lABEL.Text = "实体层：";
            // 
            // b_choice
            // 
            this.b_choice.Location = new System.Drawing.Point(668, 77);
            this.b_choice.Name = "b_choice";
            this.b_choice.Size = new System.Drawing.Size(75, 23);
            this.b_choice.TabIndex = 12;
            this.b_choice.Text = "选择";
            this.b_choice.UseVisualStyleBackColor = true;
            this.b_choice.Click += new System.EventHandler(this.b_choice_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "生成代码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_path
            // 
            this.t_path.Location = new System.Drawing.Point(77, 77);
            this.t_path.Name = "t_path";
            this.t_path.ReadOnly = true;
            this.t_path.Size = new System.Drawing.Size(585, 21);
            this.t_path.TabIndex = 1;
            this.t_path.Text = "D:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "保存路径：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(433, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "注：生成四层文件需要填写文件名称";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgridTable);
            this.groupBox2.Location = new System.Drawing.Point(12, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 475);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择表";
            // 
            // dgridTable
            // 
            this.dgridTable.AllowUserToAddRows = false;
            this.dgridTable.AllowUserToDeleteRows = false;
            this.dgridTable.AllowUserToResizeColumns = false;
            this.dgridTable.AllowUserToResizeRows = false;
            this.dgridTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridTable.ColumnHeadersVisible = false;
            this.dgridTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name});
            this.dgridTable.Location = new System.Drawing.Point(5, 20);
            this.dgridTable.MultiSelect = false;
            this.dgridTable.Name = "dgridTable";
            this.dgridTable.ReadOnly = true;
            this.dgridTable.RowHeadersVisible = false;
            this.dgridTable.RowTemplate.Height = 23;
            this.dgridTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgridTable.Size = new System.Drawing.Size(128, 449);
            this.dgridTable.TabIndex = 1;
            this.dgridTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridTable_CellClick);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvColumns);
            this.groupBox3.Location = new System.Drawing.Point(179, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(854, 348);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "服务层";
            // 
            // dgvColumns
            // 
            this.dgvColumns.AllowUserToAddRows = false;
            this.dgvColumns.AllowUserToDeleteRows = false;
            this.dgvColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.表名称,
            this.服务名,
            this.类型,
            this.查询条件,
            this.JSON值});
            this.dgvColumns.Location = new System.Drawing.Point(6, 20);
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.RowTemplate.Height = 23;
            this.dgvColumns.Size = new System.Drawing.Size(844, 322);
            this.dgvColumns.TabIndex = 0;
            // 
            // 表名称
            // 
            this.表名称.DataPropertyName = "表名称";
            this.表名称.HeaderText = "表名称";
            this.表名称.Name = "表名称";
            this.表名称.ReadOnly = true;
            // 
            // 服务名
            // 
            this.服务名.DataPropertyName = "服务名";
            this.服务名.HeaderText = "服务名";
            this.服务名.Name = "服务名";
            this.服务名.ReadOnly = true;
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "类型";
            this.类型.HeaderText = "类型";
            this.类型.Items.AddRange(new object[] {
            "HttpGet",
            "HttpPost"});
            this.类型.Name = "类型";
            // 
            // 查询条件
            // 
            this.查询条件.DataPropertyName = "查询条件";
            this.查询条件.HeaderText = "查询条件";
            this.查询条件.Name = "查询条件";
            // 
            // JSON值
            // 
            this.JSON值.DataPropertyName = "JSON值";
            this.JSON值.HeaderText = "JSON值";
            this.JSON值.Name = "JSON值";
            this.JSON值.Visible = false;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(817, 140);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 1;
            this.btnAddRow.Text = "新增服务";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.BtnAddRow_Click);
            // 
            // btnJsonEdit
            // 
            this.btnJsonEdit.Location = new System.Drawing.Point(704, 140);
            this.btnJsonEdit.Name = "btnJsonEdit";
            this.btnJsonEdit.Size = new System.Drawing.Size(75, 23);
            this.btnJsonEdit.TabIndex = 4;
            this.btnJsonEdit.Text = "JSON编辑";
            this.btnJsonEdit.UseVisualStyleBackColor = true;
            this.btnJsonEdit.Click += new System.EventHandler(this.btnJsonEdit_Click);
            // 
            // createCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 517);
            this.Controls.Add(this.btnJsonEdit);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "createCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码生成器";
            this.Load += new System.EventHandler(this.createCode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgridTable)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_choice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ControllersName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ConpontentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ManagerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelName;
        private System.Windows.Forms.Label lABEL;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.DataGridView dgridTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnJsonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn 表名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 服务名;
        private System.Windows.Forms.DataGridViewComboBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 查询条件;
        private System.Windows.Forms.DataGridViewTextBoxColumn JSON值;
    }
}