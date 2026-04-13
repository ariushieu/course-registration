namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    partial class QLSinhVien
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
            System.Windows.Forms.Panel pnlTop;
            System.Windows.Forms.Panel pnlBottom;
            System.Windows.Forms.Label lblMaSV;
            System.Windows.Forms.Label lblHoTen;
            System.Windows.Forms.Label lblLop;
            System.Windows.Forms.Label lblNgaySinh;
            System.Windows.Forms.Label lblGioiTinh;
            System.Windows.Forms.Label lblTrangThai;
            System.Windows.Forms.Label lblEmail;
            System.Windows.Forms.Label lblDienThoai;
            System.Windows.Forms.Label lblTimKiem;
            System.Windows.Forms.DataGridViewTextBoxColumn colStudentId;
            System.Windows.Forms.DataGridViewTextBoxColumn colStudentCode;
            System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
            System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
            System.Windows.Forms.DataGridViewTextBoxColumn colGender;
            System.Windows.Forms.DataGridViewTextBoxColumn colClassName;
            System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
            System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
            System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
            this.components = new System.ComponentModel.Container();
            pnlTop = new System.Windows.Forms.Panel();
            lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            lblLop = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.TextBox();
            lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            lblDienThoai = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            pnlBottom = new System.Windows.Forms.Panel();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            colStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStudentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblMaSV);
            pnlTop.Controls.Add(this.txtMaSV);
            pnlTop.Controls.Add(lblHoTen);
            pnlTop.Controls.Add(this.txtHoTen);
            pnlTop.Controls.Add(lblLop);
            pnlTop.Controls.Add(this.txtLop);
            pnlTop.Controls.Add(lblNgaySinh);
            pnlTop.Controls.Add(this.dtpNgaySinh);
            pnlTop.Controls.Add(lblGioiTinh);
            pnlTop.Controls.Add(this.cboGioiTinh);
            pnlTop.Controls.Add(lblTrangThai);
            pnlTop.Controls.Add(this.cboTrangThai);
            pnlTop.Controls.Add(lblEmail);
            pnlTop.Controls.Add(this.txtEmail);
            pnlTop.Controls.Add(lblDienThoai);
            pnlTop.Controls.Add(this.txtDienThoai);
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
            pnlTop.Size = new System.Drawing.Size(1200, 175);
            pnlTop.TabIndex = 0;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new System.Drawing.Point(20, 18);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new System.Drawing.Size(45, 16);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(110, 15);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(180, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new System.Drawing.Point(380, 18);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(49, 16);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(450, 15);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(300, 22);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblLop
            // 
            lblLop.AutoSize = true;
            lblLop.Location = new System.Drawing.Point(860, 18);
            lblLop.Name = "lblLop";
            lblLop.Size = new System.Drawing.Size(29, 16);
            lblLop.TabIndex = 4;
            lblLop.Text = "Lớp";
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(910, 15);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(180, 22);
            this.txtLop.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new System.Drawing.Point(20, 53);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new System.Drawing.Size(63, 16);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(110, 50);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(180, 22);
            this.dtpNgaySinh.TabIndex = 7;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new System.Drawing.Point(380, 53);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new System.Drawing.Size(54, 16);
            lblGioiTinh.TabIndex = 8;
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
            this.cboGioiTinh.Location = new System.Drawing.Point(450, 50);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(140, 24);
            this.cboGioiTinh.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new System.Drawing.Point(830, 53);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new System.Drawing.Size(67, 16);
            lblTrangThai.TabIndex = 10;
            lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đang học",
            "Bảo lưu",
            "Đã tốt nghiệp",
            "Ngừng học"});
            this.cboTrangThai.Location = new System.Drawing.Point(910, 50);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(180, 24);
            this.cboTrangThai.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(20, 88);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(39, 16);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // lblDienThoai
            // 
            lblDienThoai.AutoSize = true;
            lblDienThoai.Location = new System.Drawing.Point(460, 88);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new System.Drawing.Size(67, 16);
            lblDienThoai.TabIndex = 14;
            lblDienThoai.Text = "Điện thoại";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(550, 85);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 22);
            this.txtDienThoai.TabIndex = 15;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new System.Drawing.Point(830, 88);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new System.Drawing.Size(61, 16);
            lblTimKiem.TabIndex = 16;
            lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(910, 85);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(220, 22);
            this.txtTimKiem.TabIndex = 17;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTimKiem_KeyDown);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(110, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 28);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(210, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 28);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(310, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 28);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(910, 120);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 28);
            this.btnTimKiem.TabIndex = 21;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(1010, 120);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 28);
            this.btnLamMoi.TabIndex = 22;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlBottom
            // 
            pnlBottom.Controls.Add(this.dgvSinhVien);
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBottom.Location = new System.Drawing.Point(0, 175);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new System.Drawing.Size(1200, 525);
            pnlBottom.TabIndex = 1;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AutoGenerateColumns = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            colStudentId,
            colStudentCode,
            colFullName,
            colDateOfBirth,
            colGender,
            colClassName,
            colEmail,
            colPhone,
            colStatus});
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1200, 525);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.DgvSinhVien_SelectionChanged);
            // 
            // colStudentId
            // 
            colStudentId.DataPropertyName = "StudentID";
            colStudentId.HeaderText = "ID";
            colStudentId.MinimumWidth = 6;
            colStudentId.Name = "StudentID";
            colStudentId.ReadOnly = true;
            colStudentId.Width = 60;
            // 
            // colStudentCode
            // 
            colStudentCode.DataPropertyName = "StudentCode";
            colStudentCode.HeaderText = "Mã SV";
            colStudentCode.MinimumWidth = 6;
            colStudentCode.Name = "StudentCode";
            colStudentCode.ReadOnly = true;
            colStudentCode.Width = 110;
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
            // colDateOfBirth
            // 
            colDateOfBirth.DataPropertyName = "DateOfBirth";
            colDateOfBirth.HeaderText = "Ngày sinh";
            colDateOfBirth.MinimumWidth = 6;
            colDateOfBirth.Name = "DateOfBirth";
            colDateOfBirth.ReadOnly = true;
            colDateOfBirth.Width = 100;
            colDateOfBirth.DefaultCellStyle.Format = "dd/MM/yyyy";
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
            // colClassName
            // 
            colClassName.DataPropertyName = "ClassName";
            colClassName.HeaderText = "Lớp";
            colClassName.MinimumWidth = 6;
            colClassName.Name = "ClassName";
            colClassName.ReadOnly = true;
            colClassName.Width = 100;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "Email";
            colEmail.ReadOnly = true;
            colEmail.Width = 190;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Điện thoại";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "Phone";
            colPhone.ReadOnly = true;
            colPhone.Width = 120;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Trạng thái";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "Status";
            colStatus.ReadOnly = true;
            colStatus.Width = 120;
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(pnlBottom);
            this.Controls.Add(pnlTop);
            this.Name = "QLSinhVien";
            this.Text = "Quản lý Sinh viên";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}