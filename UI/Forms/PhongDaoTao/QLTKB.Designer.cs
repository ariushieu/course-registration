namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    partial class QLTKB
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
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMaLHPFilter = new System.Windows.Forms.TextBox();
            this.lblMaLHPFilter = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.btnAutoSchedule = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.gbFilter.SuspendLayout();
            this.gbAction.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.txtMaLHPFilter);
            this.gbFilter.Controls.Add(this.lblMaLHPFilter);
            this.gbFilter.Controls.Add(this.cboHocKy);
            this.gbFilter.Controls.Add(this.lblHocKy);
            this.gbFilter.Location = new System.Drawing.Point(12, 12);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(876, 70);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Bộ lọc";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(560, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtMaLHPFilter
            // 
            this.txtMaLHPFilter.Location = new System.Drawing.Point(330, 28);
            this.txtMaLHPFilter.Name = "txtMaLHPFilter";
            this.txtMaLHPFilter.Size = new System.Drawing.Size(200, 22);
            this.txtMaLHPFilter.TabIndex = 3;
            // 
            // lblMaLHPFilter
            // 
            this.lblMaLHPFilter.AutoSize = true;
            this.lblMaLHPFilter.Location = new System.Drawing.Point(250, 31);
            this.lblMaLHPFilter.Name = "lblMaLHPFilter";
            this.lblMaLHPFilter.Size = new System.Drawing.Size(60, 16);
            this.lblMaLHPFilter.TabIndex = 2;
            this.lblMaLHPFilter.Text = "Mã LHP:";
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(80, 28);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(140, 24);
            this.cboHocKy.TabIndex = 1;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(20, 31);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(52, 16);
            this.lblHocKy.TabIndex = 0;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // gbAction
            // 
            this.gbAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAction.Controls.Add(this.btnAutoSchedule);
            this.gbAction.Controls.Add(this.btnSave);
            this.gbAction.Location = new System.Drawing.Point(12, 88);
            this.gbAction.Name = "gbAction";
            this.gbAction.Size = new System.Drawing.Size(876, 60);
            this.gbAction.TabIndex = 1;
            this.gbAction.TabStop = false;
            this.gbAction.Text = "Chức năng";
            // 
            // btnAutoSchedule
            // 
            this.btnAutoSchedule.Location = new System.Drawing.Point(150, 21);
            this.btnAutoSchedule.Name = "btnAutoSchedule";
            this.btnAutoSchedule.Size = new System.Drawing.Size(150, 30);
            this.btnAutoSchedule.TabIndex = 2;
            this.btnAutoSchedule.Text = "Tự động sắp xếp";
            this.btnAutoSchedule.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu TKB";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gbData
            // 
            this.gbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbData.Controls.Add(this.dgvTKB);
            this.gbData.Location = new System.Drawing.Point(12, 154);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(876, 354);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "Thời khóa biểu";
            // 
            // dgvTKB
            // 
            this.dgvTKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTKB.Location = new System.Drawing.Point(3, 18);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.RowHeadersWidth = 51;
            this.dgvTKB.RowTemplate.Height = 24;
            this.dgvTKB.Size = new System.Drawing.Size(870, 333);
            this.dgvTKB.TabIndex = 0;
            // 
            // QLTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 520);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.gbFilter);
            this.Name = "QLTKB";
            this.Text = "Quản lý Thời khóa biểu";
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.gbAction.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMaLHPFilter;
        private System.Windows.Forms.Label lblMaLHPFilter;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.Button btnAutoSchedule;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvTKB;
    }
}