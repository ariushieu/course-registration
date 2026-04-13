namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    partial class QLGiangVien
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
            System.Windows.Forms.Label lblMaGV;
            System.Windows.Forms.Label lblHoTen;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblDienThoai;
            System.Windows.Forms.Label lblMaKhoa;
            System.Windows.Forms.Label lblTimKiem;
            System.Windows.Forms.Label lblGioiTinh;
            System.Windows.Forms.Label lblHocVi;
            System.Windows.Forms.Label lblChucDanh;
            System.Windows.Forms.DataGridViewTextBoxColumn colTeacherId;
            System.Windows.Forms.DataGridViewTextBoxColumn colTeacherCode;
            System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
            System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
            System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
            System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentId;
            System.Windows.Forms.DataGridViewTextBoxColumn colGender;
            System.Windows.Forms.DataGridViewTextBoxColumn colDegree;
            System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
            pnlTop = new System.Windows.Forms.Panel();
            lblMaGV = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            lblMaKhoa = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            lblHocVi = new System.Windows.Forms.Label();
            this.cboHocVi = new System.Windows.Forms.ComboBox();
            lblChucDanh = new System.Windows.Forms.Label();
            this.cboChucDanh = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            pnlBottom = new System.Windows.Forms.Panel();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            colTeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTeacherCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblMaGV);
            pnlTop.Controls.Add(this.txtMaGV);
            pnlTop.Controls.Add(lblHoTen);
            pnlTop.Controls.Add(this.txtHoTen);
            pnlTop.Controls.Add(lblEmail);
            pnlTop.Controls.Add(this.txtEmail);
            pnlTop.Controls.Add(lblDienThoai);
            pnlTop.Controls.Add(this.txtDienThoai);
            pnlTop.Controls.Add(lblMaKhoa);
            pnlTop.Controls.Add(this.txtKhoa);
            pnlTop.Controls.Add(lblTimKiem);
            pnlTop.Controls.Add(this.txtTimKiem);
            pnlTop.Controls.Add(lblGioiTinh);
            pnlTop.Controls.Add(this.cboGioiTinh);
            pnlTop.Controls.Add(lblHocVi);
            pnlTop.Controls.Add(this.cboHocVi);
            pnlTop.Controls.Add(lblChucDanh);
            pnlTop.Controls.Add(this.cboChucDanh);
            pnlTop.Controls.Add(this.btnThem);
            pnlTop.Controls.Add(this.btnSua);
            pnlTop.Controls.Add(this.btnXoa);
            pnlTop.Controls.Add(this.btnTimKiem);
            pnlTop.Controls.Add(this.btnLamMoi);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Location = new System.Drawing.Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(1200, 160);
            pnlTop.TabIndex = 0;
            // 
            // lblMaGV
            // 
            lblMaGV.AutoSize = true;
            lblMaGV.Location = new System.Drawing.Point(20, 18);
            lblMaGV.Name = "lblMaGV";
            lblMaGV.Size = new System.Drawing.Size(45, 16);
            lblMaGV.TabIndex = 0;
            lblMaGV.Text = "Mã GV";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(90, 15);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(180, 22);
            this.txtMaGV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new System.Drawing.Point(290, 18);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(49, 16);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(350, 15);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(180, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(590, 18);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(39, 16);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(640, 15);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new System.Drawing.Point(20, 53);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new System.Drawing.Size(67, 16);
            lblDienThoai.TabIndex = 6;
            lblDienThoai.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(90, 50);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(180, 22);
            this.txtDienThoai.TabIndex = 7;
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new System.Drawing.Point(290, 53);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new System.Drawing.Size(56, 16);
            lblMaKhoa.TabIndex = 8;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(350, 50);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(180, 22);
            this.txtKhoa.TabIndex = 9;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new System.Drawing.Point(590, 53);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new System.Drawing.Size(61, 16);
            lblTimKiem.TabIndex = 10;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(640, 50);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(180, 22);
            this.txtTimKiem.TabIndex = 11;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTimKiem_KeyDown);
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new System.Drawing.Point(20, 88);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            lblGioiTinh.TabIndex = 12;
            lblGioiTinh.Text = "Giới tính";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(90, 85);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(180, 24);
            this.cboGioiTinh.TabIndex = 13;
            // 
            // lblHocVi
            // 
            lblHocVi.AutoSize = true;
            lblHocVi.Location = new System.Drawing.Point(290, 88);
            lblHocVi.Name = "lblHocVi";
            lblHocVi.Size = new System.Drawing.Size(46, 16);
            lblHocVi.TabIndex = 14;
            lblHocVi.Text = "Học vị";
            // 
            // cboHocVi
            // 
            this.cboHocVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocVi.FormattingEnabled = true;
            this.cboHocVi.Items.AddRange(new object[] {
            "Cử nhân",
            "Thạc sĩ",
            "Tiến sĩ"});
            this.cboHocVi.Location = new System.Drawing.Point(350, 85);
            this.cboHocVi.Name = "cboHocVi";
            this.cboHocVi.Size = new System.Drawing.Size(180, 24);
            this.cboHocVi.TabIndex = 15;
            // 
            // lblChucDanh
            // 
            lblChucDanh.AutoSize = true;
            lblChucDanh.Location = new System.Drawing.Point(590, 88);
            lblChucDanh.Name = "lblChucDanh";
            lblChucDanh.Size = new System.Drawing.Size(71, 16);
            lblChucDanh.TabIndex = 16;
            lblChucDanh.Text = "Chức danh";
            // 
            // cboChucDanh
            // 
            this.cboChucDanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucDanh.FormattingEnabled = true;
            this.cboChucDanh.Items.AddRange(new object[] {
            "Giảng viên",
            "Phó giáo sư",
            "Giáo sư"});
            this.cboChucDanh.Location = new System.Drawing.Point(640, 85);
            this.cboChucDanh.Name = "cboChucDanh";
            this.cboChucDanh.Size = new System.Drawing.Size(180, 24);
            this.cboChucDanh.TabIndex = 17;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(90, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 28);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(180, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 28);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(270, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 28);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(640, 120);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 28);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(730, 120);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 28);
            this.btnLamMoi.TabIndex = 22;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(this.dgvGiangVien);
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBottom.Location = new System.Drawing.Point(0, 160);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new System.Drawing.Size(1200, 540);
            pnlBottom.TabIndex = 1;
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.AllowUserToAddRows = false;
            this.dgvGiangVien.AutoGenerateColumns = false;
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            colTeacherId,
            colTeacherCode,
            colFullName,
            colEmail,
            colPhone,
            colDepartmentId,
            colGender,
            colDegree,
            colTitle});
            this.dgvGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiangVien.Location = new System.Drawing.Point(0, 0);
            this.dgvGiangVien.MultiSelect = false;
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.ReadOnly = true;
            this.dgvGiangVien.RowHeadersWidth = 51;
            this.dgvGiangVien.RowTemplate.Height = 24;
            this.dgvGiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiangVien.Size = new System.Drawing.Size(1200, 540);
            this.dgvGiangVien.TabIndex = 0;
            this.dgvGiangVien.SelectionChanged += new System.EventHandler(this.DgvGiangVien_SelectionChanged);
            // 
            // colTeacherId
            // 
            colTeacherId.DataPropertyName = "TeacherID";
            colTeacherId.HeaderText = "ID";
            colTeacherId.MinimumWidth = 6;
            colTeacherId.Name = "TeacherID";
            colTeacherId.ReadOnly = true;
            colTeacherId.Width = 60;
            // 
            // colTeacherCode
            // 
            colTeacherCode.DataPropertyName = "TeacherCode";
            colTeacherCode.HeaderText = "Mã GV";
            colTeacherCode.MinimumWidth = 6;
            colTeacherCode.Name = "TeacherCode";
            colTeacherCode.ReadOnly = true;
            colTeacherCode.Width = 120;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Họ tên";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "FullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 220;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "Email";
            colEmail.ReadOnly = true;
            colEmail.Width = 180;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Điện thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "Phone";
            colPhone.ReadOnly = true;
            colPhone.Width = 130;
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
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Giới tính";
            colGender.MinimumWidth = 6;
            colGender.Name = "Gender";
            colGender.ReadOnly = true;
            colGender.Width = 90;
            // 
            // colDegree
            // 
            colDegree.DataPropertyName = "Degree";
            colDegree.HeaderText = "Học vị";
            colDegree.MinimumWidth = 6;
            colDegree.Name = "Degree";
            colDegree.ReadOnly = true;
            colDegree.Width = 100;
            // 
            // colTitle
            // 
            colTitle.DataPropertyName = "Title";
            colTitle.HeaderText = "Chức danh";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "Title";
            colTitle.ReadOnly = true;
            colTitle.Width = 120;
            // 
            // QLGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(pnlBottom);
            this.Controls.Add(pnlTop);
            this.Name = "QLGiangVien";
            this.Text = "Quản lý Giảng viên";
            this.Load += new System.EventHandler(this.QLGiangVien_Load);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
