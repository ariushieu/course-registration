namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    partial class QLHocPhan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.Panel pnlTop;
            System.Windows.Forms.Panel pnlBottom;
            System.Windows.Forms.Label lblMaHP;
            System.Windows.Forms.Label lblTenHocPhan;
            System.Windows.Forms.Label lblSoTinChi;
            System.Windows.Forms.Label lblMaKhoa;
            System.Windows.Forms.Label lblTimKiem;
            System.Windows.Forms.DataGridViewTextBoxColumn colCourseId;
            System.Windows.Forms.DataGridViewTextBoxColumn colCourseCode;
            System.Windows.Forms.DataGridViewTextBoxColumn colCourseName;
            System.Windows.Forms.DataGridViewTextBoxColumn colCredits;
            System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentId;
            pnlTop = new System.Windows.Forms.Panel();
            lblMaHP = new System.Windows.Forms.Label();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            lblTenHocPhan = new System.Windows.Forms.Label();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            lblSoTinChi = new System.Windows.Forms.Label();
            this.nudSoTinChi = new System.Windows.Forms.NumericUpDown();
            lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            pnlBottom = new System.Windows.Forms.Panel();
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            colCourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTinChi)).BeginInit();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblMaHP);
            pnlTop.Controls.Add(this.txtMaHP);
            pnlTop.Controls.Add(lblTenHocPhan);
            pnlTop.Controls.Add(this.txtTenHP);
            pnlTop.Controls.Add(lblSoTinChi);
            pnlTop.Controls.Add(this.nudSoTinChi);
            pnlTop.Controls.Add(lblMaKhoa);
            pnlTop.Controls.Add(this.txtMaKhoa);
            pnlTop.Controls.Add(lblTimKiem);
            pnlTop.Controls.Add(this.txtTimKiem);
            pnlTop.Controls.Add(this.btnThem);
            pnlTop.Controls.Add(this.btnSua);
            pnlTop.Controls.Add(this.btnXoa);
            pnlTop.Controls.Add(this.btnTimKiem);
            pnlTop.Controls.Add(this.btnLamMoi);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(1000, 145);
            pnlTop.TabIndex = 0;
            // 
            // lblMaHP
            // 
            lblMaHP.AutoSize = true;
            lblMaHP.Location = new System.Drawing.Point(20, 18);
            lblMaHP.Name = "lblMaHP";
            lblMaHP.Size = new System.Drawing.Size(45, 16);
            lblMaHP.TabIndex = 0;
            lblMaHP.Text = "Mã HP";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(100, 15);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(180, 22);
            this.txtMaHP.TabIndex = 1;
            // 
            // lblTenHocPhan
            // 
            lblTenHocPhan.AutoSize = true;
            lblTenHocPhan.Location = new System.Drawing.Point(320, 18);
            lblTenHocPhan.Name = "lblTenHocPhan";
            lblTenHocPhan.Size = new System.Drawing.Size(84, 16);
            lblTenHocPhan.TabIndex = 2;
            lblTenHocPhan.Text = "Tên học phần";
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(420, 15);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(260, 22);
            this.txtTenHP.TabIndex = 3;
            // 
            // lblSoTinChi
            // 
            lblSoTinChi.AutoSize = true;
            lblSoTinChi.Location = new System.Drawing.Point(20, 53);
            lblSoTinChi.Name = "lblSoTinChi";
            lblSoTinChi.Size = new System.Drawing.Size(62, 16);
            lblSoTinChi.TabIndex = 4;
            lblSoTinChi.Text = "Số tín chỉ";
            // 
            // nudSoTinChi
            // 
            this.nudSoTinChi.Location = new System.Drawing.Point(100, 50);
            this.nudSoTinChi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSoTinChi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoTinChi.Name = "nudSoTinChi";
            this.nudSoTinChi.Size = new System.Drawing.Size(80, 22);
            this.nudSoTinChi.TabIndex = 5;
            this.nudSoTinChi.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new System.Drawing.Point(320, 53);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new System.Drawing.Size(56, 16);
            lblMaKhoa.TabIndex = 6;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(420, 50);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(120, 22);
            this.txtMaKhoa.TabIndex = 7;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new System.Drawing.Point(320, 88);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new System.Drawing.Size(61, 16);
            lblTimKiem.TabIndex = 8;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(420, 85);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(260, 22);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTimKiem_KeyDown);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(700, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 28);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(700, 42);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 28);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(700, 72);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 28);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(700, 102);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 28);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(800, 102);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 28);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(this.dgvHocPhan);
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBottom.Location = new System.Drawing.Point(0, 145);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new System.Drawing.Size(1000, 455);
            pnlBottom.TabIndex = 1;
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.AllowUserToAddRows = false;
            this.dgvHocPhan.AutoGenerateColumns = false;
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            colCourseId,
            colCourseCode,
            colCourseName,
            colCredits,
            colDepartmentId});
            this.dgvHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocPhan.Location = new System.Drawing.Point(0, 0);
            this.dgvHocPhan.MultiSelect = false;
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.ReadOnly = true;
            this.dgvHocPhan.RowHeadersWidth = 51;
            this.dgvHocPhan.RowTemplate.Height = 24;
            this.dgvHocPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocPhan.Size = new System.Drawing.Size(1000, 455);
            this.dgvHocPhan.TabIndex = 0;
            this.dgvHocPhan.SelectionChanged += new System.EventHandler(this.DgvHocPhan_SelectionChanged);
            // 
            // colCourseId
            // 
            colCourseId.DataPropertyName = "CourseID";
            colCourseId.HeaderText = "ID";
            colCourseId.MinimumWidth = 6;
            colCourseId.Name = "CourseID";
            colCourseId.ReadOnly = true;
            colCourseId.Width = 60;
            // 
            // colCourseCode
            // 
            colCourseCode.DataPropertyName = "CourseCode";
            colCourseCode.HeaderText = "Mã HP";
            colCourseCode.MinimumWidth = 6;
            colCourseCode.Name = "CourseCode";
            colCourseCode.ReadOnly = true;
            colCourseCode.Width = 120;
            // 
            // colCourseName
            // 
            colCourseName.DataPropertyName = "CourseName";
            colCourseName.HeaderText = "Tên học phần";
            colCourseName.MinimumWidth = 6;
            colCourseName.Name = "CourseName";
            colCourseName.ReadOnly = true;
            colCourseName.Width = 280;
            // 
            // colCredits
            // 
            colCredits.DataPropertyName = "Credits";
            colCredits.HeaderText = "Số tín chỉ";
            colCredits.MinimumWidth = 6;
            colCredits.Name = "Credits";
            colCredits.ReadOnly = true;
            colCredits.Width = 90;
            // 
            // colDepartmentId
            // 
            colDepartmentId.DataPropertyName = "DepartmentID";
            colDepartmentId.HeaderText = "Mã khoa";
            colDepartmentId.MinimumWidth = 6;
            colDepartmentId.Name = "DepartmentID";
            colDepartmentId.ReadOnly = true;
            colDepartmentId.Width = 90;
            // 
            // QLHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(pnlBottom);
            this.Controls.Add(pnlTop);
            this.Name = "QLHocPhan";
            this.Text = "Quản lý Học phần";
            this.Load += new System.EventHandler(this.QLHocPhan_Load);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoTinChi)).EndInit();
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
