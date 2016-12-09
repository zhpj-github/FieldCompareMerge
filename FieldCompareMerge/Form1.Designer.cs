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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataBaseAddress = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.dataGridViewTarget = new System.Windows.Forms.DataGridView();
            this.dataGridViewSource = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combSelectedField = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInputTable = new System.Windows.Forms.Button();
            this.btnOutputTarget = new System.Windows.Forms.Button();
            this.btnOutputSource = new System.Windows.Forms.Button();
            this.btnCopyToSource = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtXmlPath = new System.Windows.Forms.TextBox();
            this.btnAutoCopy = new System.Windows.Forms.Button();
            this.combKeyField = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSelectCopy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTargetTableName = new System.Windows.Forms.Label();
            this.lblSourceTableName = new System.Windows.Forms.Label();
            this.panelDB = new System.Windows.Forms.Panel();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.btnCloseDB = new System.Windows.Forms.Button();
            this.dataGridViewTemp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.subMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSource)).BeginInit();
            this.panelDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // txtDataBaseAddress
            // 
            this.txtDataBaseAddress.Location = new System.Drawing.Point(86, 2);
            this.txtDataBaseAddress.Name = "txtDataBaseAddress";
            this.txtDataBaseAddress.Size = new System.Drawing.Size(229, 21);
            this.txtDataBaseAddress.TabIndex = 4;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(86, 29);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(229, 21);
            this.txtDatabase.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(86, 56);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(76, 21);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "sa";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(215, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "zz863$senlun";
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.Enabled = false;
            this.btnSelectTable.Location = new System.Drawing.Point(363, 8);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(75, 23);
            this.btnSelectTable.TabIndex = 5;
            this.btnSelectTable.Text = "选择目标表";
            this.btnSelectTable.UseVisualStyleBackColor = true;
            this.btnSelectTable.Click += new System.EventHandler(this.btnSelectTable_Click);
            // 
            // dataGridViewTarget
            // 
            this.dataGridViewTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTarget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarget.Location = new System.Drawing.Point(14, 204);
            this.dataGridViewTarget.MultiSelect = false;
            this.dataGridViewTarget.Name = "dataGridViewTarget";
            this.dataGridViewTarget.ReadOnly = true;
            this.dataGridViewTarget.RowTemplate.Height = 23;
            this.dataGridViewTarget.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTarget.Size = new System.Drawing.Size(254, 204);
            this.dataGridViewTarget.TabIndex = 6;
            // 
            // dataGridViewSource
            // 
            this.dataGridViewSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSource.Location = new System.Drawing.Point(544, 204);
            this.dataGridViewSource.MultiSelect = false;
            this.dataGridViewSource.Name = "dataGridViewSource";
            this.dataGridViewSource.ReadOnly = true;
            this.dataGridViewSource.RowTemplate.Height = 23;
            this.dataGridViewSource.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSource.Size = new System.Drawing.Size(272, 204);
            this.dataGridViewSource.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "目标表:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "源表:";
            // 
            // combSelectedField
            // 
            this.combSelectedField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSelectedField.FormattingEnabled = true;
            this.combSelectedField.Items.AddRange(new object[] {
            "SYS_GUID"});
            this.combSelectedField.Location = new System.Drawing.Point(420, 67);
            this.combSelectedField.Name = "combSelectedField";
            this.combSelectedField.Size = new System.Drawing.Size(121, 20);
            this.combSelectedField.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "合并字段：";
            // 
            // btnInputTable
            // 
            this.btnInputTable.Location = new System.Drawing.Point(708, 38);
            this.btnInputTable.Name = "btnInputTable";
            this.btnInputTable.Size = new System.Drawing.Size(75, 23);
            this.btnInputTable.TabIndex = 15;
            this.btnInputTable.Text = "导入源表";
            this.btnInputTable.UseVisualStyleBackColor = true;
            this.btnInputTable.Click += new System.EventHandler(this.btnInputTable_Click);
            // 
            // btnOutputTarget
            // 
            this.btnOutputTarget.Location = new System.Drawing.Point(14, 158);
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
            this.btnOutputSource.Location = new System.Drawing.Point(537, 175);
            this.btnOutputSource.Name = "btnOutputSource";
            this.btnOutputSource.Size = new System.Drawing.Size(75, 23);
            this.btnOutputSource.TabIndex = 17;
            this.btnOutputSource.Text = "导出源表";
            this.btnOutputSource.UseVisualStyleBackColor = true;
            this.btnOutputSource.Click += new System.EventHandler(this.btnOutputSource_Click);
            // 
            // btnCopyToSource
            // 
            this.btnCopyToSource.Location = new System.Drawing.Point(158, 175);
            this.btnCopyToSource.Name = "btnCopyToSource";
            this.btnCopyToSource.Size = new System.Drawing.Size(110, 23);
            this.btnCopyToSource.TabIndex = 18;
            this.btnCopyToSource.Text = "附加到XML";
            this.btnCopyToSource.UseVisualStyleBackColor = true;
            this.btnCopyToSource.Click += new System.EventHandler(this.btnCopyToSource_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "源路径：";
            // 
            // txtXmlPath
            // 
            this.txtXmlPath.Location = new System.Drawing.Point(420, 40);
            this.txtXmlPath.Name = "txtXmlPath";
            this.txtXmlPath.ReadOnly = true;
            this.txtXmlPath.Size = new System.Drawing.Size(281, 21);
            this.txtXmlPath.TabIndex = 20;
            // 
            // btnAutoCopy
            // 
            this.btnAutoCopy.Location = new System.Drawing.Point(341, 143);
            this.btnAutoCopy.Name = "btnAutoCopy";
            this.btnAutoCopy.Size = new System.Drawing.Size(135, 25);
            this.btnAutoCopy.TabIndex = 22;
            this.btnAutoCopy.Text = "合并相同关键字项";
            this.btnAutoCopy.UseVisualStyleBackColor = true;
            this.btnAutoCopy.Click += new System.EventHandler(this.btnAutoCopy_Click);
            // 
            // combKeyField
            // 
            this.combKeyField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combKeyField.FormattingEnabled = true;
            this.combKeyField.Location = new System.Drawing.Point(420, 94);
            this.combKeyField.Name = "combKeyField";
            this.combKeyField.Size = new System.Drawing.Size(121, 20);
            this.combKeyField.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "关键字段：";
            // 
            // btnSelectCopy
            // 
            this.btnSelectCopy.Location = new System.Drawing.Point(341, 175);
            this.btnSelectCopy.Name = "btnSelectCopy";
            this.btnSelectCopy.Size = new System.Drawing.Size(135, 23);
            this.btnSelectCopy.TabIndex = 23;
            this.btnSelectCopy.Text = "合并选择项";
            this.btnSelectCopy.UseVisualStyleBackColor = true;
            this.btnSelectCopy.Click += new System.EventHandler(this.btnSelectCopy_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(569, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 47);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTargetTableName
            // 
            this.lblTargetTableName.AutoSize = true;
            this.lblTargetTableName.Location = new System.Drawing.Point(59, 184);
            this.lblTargetTableName.Name = "lblTargetTableName";
            this.lblTargetTableName.Size = new System.Drawing.Size(59, 12);
            this.lblTargetTableName.TabIndex = 26;
            this.lblTargetTableName.Text = "tableName";
            // 
            // lblSourceTableName
            // 
            this.lblSourceTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSourceTableName.AutoSize = true;
            this.lblSourceTableName.Location = new System.Drawing.Point(642, 184);
            this.lblSourceTableName.Name = "lblSourceTableName";
            this.lblSourceTableName.Size = new System.Drawing.Size(59, 12);
            this.lblSourceTableName.TabIndex = 27;
            this.lblSourceTableName.Text = "tableName";
            // 
            // panelDB
            // 
            this.panelDB.Controls.Add(this.txtStationName);
            this.panelDB.Controls.Add(this.lblName);
            this.panelDB.Controls.Add(this.label1);
            this.panelDB.Controls.Add(this.label2);
            this.panelDB.Controls.Add(this.label3);
            this.panelDB.Controls.Add(this.label4);
            this.panelDB.Controls.Add(this.txtDataBaseAddress);
            this.panelDB.Controls.Add(this.txtDatabase);
            this.panelDB.Controls.Add(this.txtUser);
            this.panelDB.Controls.Add(this.txtPassword);
            this.panelDB.Location = new System.Drawing.Point(14, 8);
            this.panelDB.Name = "panelDB";
            this.panelDB.Size = new System.Drawing.Size(323, 103);
            this.panelDB.TabIndex = 28;
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(86, 80);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(229, 21);
            this.txtStationName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 12);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "搅拌站名称：";
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(164, 118);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDB.TabIndex = 29;
            this.btnOpenDB.Text = "连接";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // btnCloseDB
            // 
            this.btnCloseDB.Enabled = false;
            this.btnCloseDB.Location = new System.Drawing.Point(254, 118);
            this.btnCloseDB.Name = "btnCloseDB";
            this.btnCloseDB.Size = new System.Drawing.Size(75, 23);
            this.btnCloseDB.TabIndex = 30;
            this.btnCloseDB.Text = "断开";
            this.btnCloseDB.UseVisualStyleBackColor = true;
            this.btnCloseDB.Click += new System.EventHandler(this.btnCloseDB_Click);
            // 
            // dataGridViewTemp
            // 
            this.dataGridViewTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemp.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTemp.Location = new System.Drawing.Point(304, 204);
            this.dataGridViewTemp.Name = "dataGridViewTemp";
            this.dataGridViewTemp.ReadOnly = true;
            this.dataGridViewTemp.RowTemplate.Height = 23;
            this.dataGridViewTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTemp.Size = new System.Drawing.Size(218, 204);
            this.dataGridViewTemp.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuItemDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // subMenuItemDel
            // 
            this.subMenuItemDel.Name = "subMenuItemDel";
            this.subMenuItemDel.Size = new System.Drawing.Size(100, 22);
            this.subMenuItemDel.Text = "删除";
            this.subMenuItemDel.Click += new System.EventHandler(this.subMenuItemDel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 475);
            this.Controls.Add(this.dataGridViewTemp);
            this.Controls.Add(this.dataGridViewSource);
            this.Controls.Add(this.dataGridViewTarget);
            this.Controls.Add(this.btnCloseDB);
            this.Controls.Add(this.btnOpenDB);
            this.Controls.Add(this.panelDB);
            this.Controls.Add(this.lblSourceTableName);
            this.Controls.Add(this.lblTargetTableName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectCopy);
            this.Controls.Add(this.btnAutoCopy);
            this.Controls.Add(this.txtXmlPath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCopyToSource);
            this.Controls.Add(this.btnOutputSource);
            this.Controls.Add(this.btnOutputTarget);
            this.Controls.Add(this.btnInputTable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combKeyField);
            this.Controls.Add(this.combSelectedField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSelectTable);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字段对比与合并";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSource)).EndInit();
            this.panelDB.ResumeLayout(false);
            this.panelDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridViewTarget;
        private System.Windows.Forms.DataGridView dataGridViewSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combSelectedField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnInputTable;
        private System.Windows.Forms.Button btnOutputTarget;
        private System.Windows.Forms.Button btnOutputSource;
        private System.Windows.Forms.Button btnCopyToSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtXmlPath;
        private System.Windows.Forms.Button btnAutoCopy;
        private System.Windows.Forms.ComboBox combKeyField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSelectCopy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTargetTableName;
        private System.Windows.Forms.Label lblSourceTableName;
        private System.Windows.Forms.Panel panelDB;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Button btnCloseDB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.DataGridView dataGridViewTemp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem subMenuItemDel;
    }
}

