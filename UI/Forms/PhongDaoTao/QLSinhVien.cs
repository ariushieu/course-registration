using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    /// <summary>
    /// Form quản lý sinh viên
    /// </summary>
    public partial class QLSinhVien : Form
    {
        private readonly List<StudentItem> _students = new List<StudentItem>();
        private int? _selectedStudentId;

        private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        private static readonly Regex PhoneRegex = new Regex(@"^\d{9,11}$", RegexOptions.Compiled);

        private DataGridView dgvSinhVien;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtDienThoai;
        private TextBox txtLop;
        private TextBox txtTimKiem;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnLamMoi;

        public QLSinhVien()
        {
            InitializeComponent();
            Load += QLSinhVien_Load;
        }

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
            SeedData();
            BindGrid(_students);
            ClearInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            if (_students.Any(x => x.StudentCode.Equals(txtMaSV.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _students.Add(new StudentItem
            {
                StudentID = _students.Count == 0 ? 1 : _students.Max(x => x.StudentID) + 1,
                StudentCode = txtMaSV.Text.Trim(),
                FullName = txtHoTen.Text.Trim(),
                DateOfBirth = dtpNgaySinh.Value.Date,
                Gender = cboGioiTinh.Text,
                ClassName = txtLop.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtDienThoai.Text.Trim(),
                Status = cboTrangThai.Text,
                CreatedDate = DateTime.Now
            });

            BindGrid(_students);
            ClearInput();
            txtMaSV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedStudentId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            var student = _students.FirstOrDefault(x => x.StudentID == _selectedStudentId.Value);
            if (student == null)
            {
                return;
            }

            if (_students.Any(x => x.StudentID != student.StudentID && x.StudentCode.Equals(txtMaSV.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            student.StudentCode = txtMaSV.Text.Trim();
            student.FullName = txtHoTen.Text.Trim();
            student.DateOfBirth = dtpNgaySinh.Value.Date;
            student.Gender = cboGioiTinh.Text;
            student.ClassName = txtLop.Text.Trim();
            student.Email = txtEmail.Text.Trim();
            student.Phone = txtDienThoai.Text.Trim();
            student.Status = cboTrangThai.Text;

            BindGrid(_students);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedStudentId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = _students.FirstOrDefault(x => x.StudentID == _selectedStudentId.Value);
            if (student == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _students.Remove(student);
            BindGrid(_students);
            ClearInput();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                BindGrid(_students);
                return;
            }

            var filtered = _students.Where(x =>
                (!string.IsNullOrWhiteSpace(x.StudentCode) && x.StudentCode.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.FullName) && x.FullName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Email) && x.Email.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Phone) && x.Phone.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.ClassName) && x.ClassName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Status) && x.Status.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0));

            BindGrid(filtered);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            BindGrid(_students);
            ClearInput();
            dgvSinhVien.ClearSelection();
            txtMaSV.Focus();
        }

        private void InitializeCustomControls()
        {
            ClientSize = new System.Drawing.Size(1200, 700);
            Text = "Quản lý Sinh viên";

            var pnlTop = new Panel { Dock = DockStyle.Top, Height = 175 };
            var pnlBottom = new Panel { Dock = DockStyle.Fill };

            txtMaSV = new TextBox { Left = 110, Top = 15, Width = 180 };
            txtHoTen = new TextBox { Left = 450, Top = 15, Width = 300 };
            txtLop = new TextBox { Left = 910, Top = 15, Width = 180 };

            dtpNgaySinh = new DateTimePicker { Left = 110, Top = 50, Width = 180, Format = DateTimePickerFormat.Short };
            cboGioiTinh = new ComboBox { Left = 450, Top = 50, Width = 140, DropDownStyle = ComboBoxStyle.DropDownList };
            cboGioiTinh.Items.AddRange(new[] { "Nam", "Nữ", "Khác" });
            cboTrangThai = new ComboBox { Left = 910, Top = 50, Width = 180, DropDownStyle = ComboBoxStyle.DropDownList };
            cboTrangThai.Items.AddRange(new[] { "Đang học", "Bảo lưu", "Đã tốt nghiệp", "Ngừng học" });

            txtEmail = new TextBox { Left = 110, Top = 85, Width = 300 };
            txtDienThoai = new TextBox { Left = 550, Top = 85, Width = 200 };
            txtTimKiem = new TextBox { Left = 910, Top = 85, Width = 220 };
            txtTimKiem.KeyDown += TxtTimKiem_KeyDown;

            btnThem = CreateButton("Thêm", 110, 120, btnThem_Click);
            btnSua = CreateButton("Sửa", 210, 120, btnSua_Click);
            btnXoa = CreateButton("Xóa", 310, 120, btnXoa_Click);
            btnTimKiem = CreateButton("Tìm", 910, 120, btnTimKiem_Click);
            btnLamMoi = CreateButton("Làm mới", 1010, 120, btnLamMoi_Click);

            pnlTop.Controls.AddRange(new Control[]
            {
                new Label { Text = "Mã SV", Left = 20, Top = 18, AutoSize = true }, txtMaSV,
                new Label { Text = "Họ tên", Left = 380, Top = 18, AutoSize = true }, txtHoTen,
                new Label { Text = "Lớp", Left = 860, Top = 18, AutoSize = true }, txtLop,

                new Label { Text = "Ngày sinh", Left = 20, Top = 53, AutoSize = true }, dtpNgaySinh,
                new Label { Text = "Giới tính", Left = 380, Top = 53, AutoSize = true }, cboGioiTinh,
                new Label { Text = "Trạng thái", Left = 830, Top = 53, AutoSize = true }, cboTrangThai,

                new Label { Text = "Email", Left = 20, Top = 88, AutoSize = true }, txtEmail,
                new Label { Text = "Điện thoại", Left = 460, Top = 88, AutoSize = true }, txtDienThoai,
                new Label { Text = "Tìm kiếm", Left = 830, Top = 88, AutoSize = true }, txtTimKiem,

                btnThem, btnSua, btnXoa, btnTimKiem, btnLamMoi
            });

            dgvSinhVien = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false
            };
            dgvSinhVien.SelectionChanged += DgvSinhVien_SelectionChanged;

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentID", DataPropertyName = "StudentID", HeaderText = "ID", Width = 60 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentCode", DataPropertyName = "StudentCode", HeaderText = "Mã SV", Width = 110 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", DataPropertyName = "FullName", HeaderText = "Họ tên", Width = 220 });

            var dobColumn = new DataGridViewTextBoxColumn { Name = "DateOfBirth", DataPropertyName = "DateOfBirth", HeaderText = "Ngày sinh", Width = 100 };
            dobColumn.DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSinhVien.Columns.Add(dobColumn);

            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Gender", DataPropertyName = "Gender", HeaderText = "Giới tính", Width = 90 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "ClassName", DataPropertyName = "ClassName", HeaderText = "Lớp", Width = 100 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email", Width = 190 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Phone", DataPropertyName = "Phone", HeaderText = "Điện thoại", Width = 120 });
            dgvSinhVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", DataPropertyName = "Status", HeaderText = "Trạng thái", Width = 120 });

            pnlBottom.Controls.Add(dgvSinhVien);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
        }

        private static Button CreateButton(string text, int x, int y, EventHandler onClick)
        {
            var button = new Button { Text = text, Left = x, Top = y, Width = 90 };
            button.Click += onClick;
            return button;
        }

        private void SeedData()
        {
            if (_students.Count > 0)
            {
                return;
            }

            _students.Add(new StudentItem
            {
                StudentID = 1,
                StudentCode = "SV001",
                FullName = "Nguyễn Minh Châu",
                DateOfBirth = new DateTime(2004, 5, 12),
                Gender = "Nữ",
                ClassName = "D21CNTT01",
                Email = "chau.nguyen@student.univ.edu.vn",
                Phone = "0901234567",
                Status = "Đang học",
                CreatedDate = DateTime.Now
            });

            _students.Add(new StudentItem
            {
                StudentID = 2,
                StudentCode = "SV002",
                FullName = "Trần Quốc Bảo",
                DateOfBirth = new DateTime(2003, 11, 20),
                Gender = "Nam",
                ClassName = "D21CNTT02",
                Email = "bao.tran@student.univ.edu.vn",
                Phone = "0912345678",
                Status = "Đang học",
                CreatedDate = DateTime.Now
            });
        }

        private void BindGrid(IEnumerable<StudentItem> source)
        {
            dgvSinhVien.DataSource = source
                .OrderBy(x => x.StudentID)
                .Select(x => new
                {
                    x.StudentID,
                    x.StudentCode,
                    x.FullName,
                    x.DateOfBirth,
                    x.Gender,
                    x.ClassName,
                    x.Email,
                    x.Phone,
                    x.Status
                })
                .ToList();

            _selectedStudentId = null;
            dgvSinhVien.ClearSelection();
        }

        private void DgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null || dgvSinhVien.CurrentRow.Cells["StudentID"].Value == null)
            {
                return;
            }

            _selectedStudentId = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["StudentID"].Value);
            var current = _students.FirstOrDefault(x => x.StudentID == _selectedStudentId.Value);
            if (current == null)
            {
                return;
            }

            txtMaSV.Text = current.StudentCode;
            txtHoTen.Text = current.FullName;
            dtpNgaySinh.Value = current.DateOfBirth;
            cboGioiTinh.Text = current.Gender;
            txtLop.Text = current.ClassName;
            txtEmail.Text = current.Email;
            txtDienThoai.Text = current.Phone;
            cboTrangThai.Text = current.Status;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã SV, họ tên và lớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpNgaySinh.Value.Date >= DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var age = DateTime.Today.Year - dtpNgaySinh.Value.Year;
            if (dtpNgaySinh.Value.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }

            if (age < 16)
            {
                MessageBox.Show("Sinh viên phải từ 16 tuổi trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var email = txtEmail.Text.Trim();
            if (!string.IsNullOrWhiteSpace(email) && !EmailRegex.IsMatch(email))
            {
                MessageBox.Show("Email không đúng định dạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            var phone = txtDienThoai.Text.Trim();
            if (!string.IsNullOrWhiteSpace(phone) && !PhoneRegex.IsMatch(phone))
            {
                MessageBox.Show("Số điện thoại chỉ gồm 9-11 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            txtLop.Clear();
            dtpNgaySinh.Value = new DateTime(2004, 1, 1);
            cboGioiTinh.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            _selectedStudentId = null;
        }

        private void TxtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private class StudentItem
        {
            public int StudentID { get; set; }
            public string StudentCode { get; set; }
            public string FullName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string ClassName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Status { get; set; }
            public DateTime CreatedDate { get; set; }
        }
    }
}
