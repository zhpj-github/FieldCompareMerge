namespace FieldCompareMerge
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataBaseAddress = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combSelectedField = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuid = new System.Windows.Forms.Button();
            this.btnInputTable = new System.Windows.Forms.Button();
            this.btnOutputTarget = new System.Windows.Forms.Button();
            this.btnOutputSource = new System.Windows.Forms.Button();
            this.btnCopyToSource = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXmlPath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // txtDataBaseAddress
            // 
            this.txtDataBaseAddress.Location = new System.Drawing.Point(108, 10);
            this.txtDataBaseAddress.Name = "txtDataBaseAddress";
            this.txtDataBaseAddress.Size = new System.Drawing.Size(229, 21);
            this.txtDataBaseAddress.TabIndex = 4;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(108, 37);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(229, 21);
            this.txtDatabase.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(108, 64);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 21);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "sa";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 4;
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.Location = new System.Drawing.Point(262, 89);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTable.TabIndex = 5;
            this.btnSelectTable.Text = "选择目标表";
            this.btnSelectTable.UseVisualStyleBackColor = true;
            this.btnSelectTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(330, 173);
            this.dataGridView1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 199);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(643, 173);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(309, 173);
            this.dataGridView2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "目标表";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "源表";
            // 
            // combSelectedField
            // 
            this.combSelectedField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSelectedField.FormattingEnabled = true;
            this.combSelectedField.Location = new System.Drawing.Point(108, 122);
            this.combSelectedField.Name = "combSelectedField";
            this.combSelectedField.Size = new System.Drawing.Size(121, 20);
            this.combSelectedField.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "合并字段：";
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(108, 148);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(229, 21);
            this.txtGuid.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "GUID：";
            // 
            // btnGuid
            // 
            this.btnGuid.Location = new System.Drawing.Point(343, 146);
            this.btnGuid.Name = "btnGuid";
            this.btnGuid.Size = new System.Drawing.Size(75, 23);
            this.btnGuid.TabIndex = 14;
            this.btnGuid.Text = "Get GUID";
            this.btnGuid.UseVisualStyleBackColor = true;
            this.btnGuid.Click += new System.EventHandler(this.btnGuid_Click);
            // 
            // btnInputTable
            // 
            this.btnInputTable.Location = new System.Drawing.Point(571, 89);
            this.btnInputTable.Name = "btnInputTable";
            this.btnInputTable.Size = new System.Drawing.Size(75, 23);
            this.btnInputTable.TabIndex = 15;
            this.btnInputTable.Text = "导入源表";
            this.btnInputTable.UseVisualStyleBackColor = true;
            this.btnInputTable.Click += new System.EventHandler(this.btnInputTable_Click);
            // 
            // btnOutputTarget
            // 
            this.btnOutputTarget.Location = new System.Drawing.Point(59, 175);
            this.btnOutputTarget.Name = "btnOutputTarget";
            this.btnOutputTarget.Size = new System.Drawing.Size(75, 23);
            this.btnOutputTarget.TabIndex = 16;
            this.btnOutputTarget.Text = "导出目标表";
            this.btnOutputTarget.UseVisualStyleBackColor = true;
            this.btnOutputTarget.Click += new System.EventHandler(this.btnOutputTarget_Click);
            // 
            // btnOutputSource
            // 
            this.btnOutputSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputSource.Location = new System.Drawing.Point(545, 175);
            this.btnOutputSource.Name = "btnOutputSource";
            this.btnOutputSource.Size = new System.Drawing.Size(75, 23);
            this.btnOutputSource.TabIndex = 17;
            this.btnOutputSource.Text = "导出源表";
            this.btnOutputSource.UseVisualStyleBackColor = true;
            this.btnOutputSource.Click += new System.EventHandler(this.btnOutputSource_Click);
            // 
            // btnCopyToSource
            // 
            this.btnCopyToSource.Location = new System.Drawing.Point(168, 175);
            this.btnCopyToSource.Name = "btnCopyToSource";
            this.btnCopyToSource.Size = new System.Drawing.Size(75, 23);
            this.btnCopyToSource.TabIndex = 18;
            this.btnCopyToSource.Text = "复制到源表";
            this.btnCopyToSource.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "源路径：";
            // 
            // txtXmlPath
            // 
            this.txtXmlPath.Location = new System.Drawing.Point(378, 37);
            this.txtXmlPath.Name = "txtXmlPath";
            this.txtXmlPath.ReadOnly = true;
            this.txtXmlPath.Size = new System.Drawing.Size(253, 21);
            this.txtXmlPath.TabIndex = 20;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(435, 13);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 21;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 384);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtXmlPath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCopyToSource);
            this.Controls.Add(this.btnOutputSource);
            this.Controls.Add(this.btnOutputTarget);
            this.Controls.Add(this.btnInputTable);
            this.Controls.Add(this.btnGuid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combSelectedField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnSelectTable);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtDataBaseAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "字段对比与合并";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataBaseAddress;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combSelectedField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuid;
        private System.Windows.Forms.Button btnInputTable;
        private System.Windows.Forms.Button btnOutputTarget;
        private System.Windows.Forms.Button btnOutputSource;
        private System.Windows.Forms.Button btnCopyToSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXmlPath;
        private System.Windows.Forms.Button btnSelectFile;
    }
}

