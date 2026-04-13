using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseRegistration.DTO.Entities;
using TeacherEntity = CourseRegistration.DTO.Entities.Teacher;

namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    /// <summary>
    /// Form quản lý thông tin Giảng viên
    /// </summary>
    public partial class QLGiangVien : Form
    {
        private readonly List<TeacherEntity> _teachers = new List<TeacherEntity>();
        private int? _selectedTeacherId;

        private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        private static readonly Regex PhoneRegex = new Regex(@"^\d{9,11}$", RegexOptions.Compiled);

        private DataGridView dgvGiangVien;
        private TextBox txtMaGV;
        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtDienThoai;
        private TextBox txtKhoa;
        private TextBox txtTimKiem;
        private ComboBox cboGioiTinh;
        private ComboBox cboHocVi;
        private ComboBox cboChucDanh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnLamMoi;

        public QLGiangVien()
        {
            InitializeComponent();
        }

        private void QLGiangVien_Load(object sender, EventArgs e)
        {
            SeedData();
            BindGrid(_teachers);
            ClearInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out var departmentId))
            {
                return;
            }

            if (_teachers.Any(x => x.TeacherCode.Equals(txtMaGV.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã giảng viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _teachers.Add(new TeacherEntity
            {
                TeacherID = _teachers.Count == 0 ? 1 : _teachers.Max(x => x.TeacherID) + 1,
                TeacherCode = txtMaGV.Text.Trim(),
                FullName = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtDienThoai.Text.Trim(),
                DepartmentID = departmentId,
                Gender = cboGioiTinh.Text,
                Degree = cboHocVi.Text,
                Title = cboChucDanh.Text,
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            BindGrid(_teachers);
            ClearInput();
            txtMaGV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedTeacherId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(out var departmentId))
            {
                return;
            }

            var teacherId = _selectedTeacherId.Value;
            var current = _teachers.FirstOrDefault(x => x.TeacherID == teacherId);
            if (current == null)
            {
                return;
            }

            if (_teachers.Any(x => x.TeacherID != teacherId && x.TeacherCode.Equals(txtMaGV.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã giảng viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            current.TeacherCode = txtMaGV.Text.Trim();
            current.FullName = txtHoTen.Text.Trim();
            current.Email = txtEmail.Text.Trim();
            current.Phone = txtDienThoai.Text.Trim();
            current.DepartmentID = departmentId;
            current.Gender = cboGioiTinh.Text;
            current.Degree = cboHocVi.Text;
            current.Title = cboChucDanh.Text;

            BindGrid(_teachers);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedTeacherId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var current = _teachers.FirstOrDefault(x => x.TeacherID == _selectedTeacherId.Value);
            if (current == null)
            {
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa giảng viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            _teachers.Remove(current);
            BindGrid(_teachers);
            ClearInput();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                BindGrid(_teachers);
                return;
            }

            var filtered = _teachers.Where(x =>
                (!string.IsNullOrWhiteSpace(x.TeacherCode) && x.TeacherCode.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.FullName) && x.FullName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Email) && x.Email.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Phone) && x.Phone.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (x.DepartmentID.HasValue && x.DepartmentID.Value.ToString().Contains(keyword)) ||
                (!string.IsNullOrWhiteSpace(x.Gender) && x.Gender.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Degree) && x.Degree.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Title) && x.Title.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0));

            BindGrid(filtered);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            BindGrid(_teachers);
            ClearInput();
            _selectedTeacherId = null;
            dgvGiangVien.ClearSelection();
            txtMaGV.Focus();
        }

        private void InitializeCustomControls()
        {
            var pnlTop = new Panel { Dock = DockStyle.Top, Height = 160 };
            var pnlBottom = new Panel { Dock = DockStyle.Fill };

            txtMaGV = CreateTextBox(90, 15);
            txtHoTen = CreateTextBox(350, 15);
            txtEmail = CreateTextBox(640, 15);
            txtDienThoai = CreateTextBox(90, 50);
            txtKhoa = CreateTextBox(350, 50);
            txtTimKiem = CreateTextBox(640, 50);
            txtTimKiem.KeyDown += TxtTimKiem_KeyDown;

            cboGioiTinh = CreateComboBox(90, 85, new[] { "Nam", "Nữ", "Khác" });
            cboHocVi = CreateComboBox(350, 85, new[] { "Cử nhân", "Thạc sĩ", "Tiến sĩ" });
            cboChucDanh = CreateComboBox(640, 85, new[] { "Giảng viên", "Phó giáo sư", "Giáo sư" });

            btnThem = CreateButton("Thêm", 90, 120, btnThem_Click);
            btnSua = CreateButton("Sửa", 180, 120, btnSua_Click);
            btnXoa = CreateButton("Xóa", 270, 120, btnXoa_Click);
            btnTimKiem = CreateButton("Tìm", 640, 120, btnTimKiem_Click);
            btnLamMoi = CreateButton("Làm mới", 730, 120, btnLamMoi_Click);

            pnlTop.Controls.AddRange(new Control[]
            {
                CreateLabel("Mã GV", 20, 18), txtMaGV,
                CreateLabel("Họ tên", 290, 18), txtHoTen,
                CreateLabel("Email", 590, 18), txtEmail,
                CreateLabel("Điện thoại", 20, 53), txtDienThoai,
                CreateLabel("Mã khoa", 290, 53), txtKhoa,
                CreateLabel("Tìm kiếm", 590, 53), txtTimKiem,
                CreateLabel("Giới tính", 20, 88), cboGioiTinh,
                CreateLabel("Học vị", 290, 88), cboHocVi,
                CreateLabel("Chức danh", 590, 88), cboChucDanh,
                btnThem, btnSua, btnXoa, btnTimKiem, btnLamMoi
            });

            dgvGiangVien = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false
            };
            dgvGiangVien.SelectionChanged += DgvGiangVien_SelectionChanged;

            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "TeacherID", DataPropertyName = "TeacherID", HeaderText = "ID", Width = 60 });
            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "TeacherCode", DataPropertyName = "TeacherCode", HeaderText = "Mã GV", Width = 120 });
            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "FullName", DataPropertyName = "FullName", HeaderText = "Họ tên", Width = 220 });
            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email", Width = 180 });
            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Phone", DataPropertyName = "Phone", HeaderText = "Điện thoại", Width = 130 });
            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "DepartmentID", DataPropertyName = "DepartmentID", HeaderText = "Mã khoa", Width = 90 });
            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Gender", DataPropertyName = "Gender", HeaderText = "Giới tính", Width = 90 });
            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Degree", DataPropertyName = "Degree", HeaderText = "Học vị", Width = 100 });
            dgvGiangVien.Columns.Add(new DataGridViewTextBoxColumn { Name = "Title", DataPropertyName = "Title", HeaderText = "Chức danh", Width = 120 });

            pnlBottom.Controls.Add(dgvGiangVien);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
        }

        private static Label CreateLabel(string text, int x, int y)
        {
            return new Label { Text = text, Left = x, Top = y, AutoSize = true };
        }

        private static TextBox CreateTextBox(int x, int y)
        {
            return new TextBox { Left = x, Top = y, Width = 180 };
        }

        private static ComboBox CreateComboBox(int x, int y, string[] items)
        {
            var combo = new ComboBox { Left = x, Top = y, Width = 180, DropDownStyle = ComboBoxStyle.DropDownList };
            combo.Items.AddRange(items);
            if (combo.Items.Count > 0)
            {
                combo.SelectedIndex = 0;
            }

            return combo;
        }

        private static Button CreateButton(string text, int x, int y, EventHandler onClick)
        {
            var button = new Button { Text = text, Left = x, Top = y, Width = 80 };
            button.Click += onClick;
            return button;
        }

        private void SeedData()
        {
            if (_teachers.Count > 0)
            {
                return;
            }

            _teachers.Add(new TeacherEntity
            {
                TeacherID = 1,
                TeacherCode = "GV001",
                FullName = "Nguyễn Văn An",
                Email = "an.nguyen@univ.edu.vn",
                Phone = "0901234567",
                DepartmentID = 1,
                Gender = "Nam",
                Degree = "Thạc sĩ",
                Title = "Giảng viên",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            _teachers.Add(new TeacherEntity
            {
                TeacherID = 2,
                TeacherCode = "GV002",
                FullName = "Trần Thị Bình",
                Email = "binh.tran@univ.edu.vn",
                Phone = "0912345678",
                DepartmentID = 2,
                Gender = "Nữ",
                Degree = "Tiến sĩ",
                Title = "Phó giáo sư",
                IsActive = true,
                CreatedDate = DateTime.Now
            });
        }

        private void BindGrid(IEnumerable<TeacherEntity> source)
        {
            dgvGiangVien.DataSource = source
                .OrderBy(x => x.TeacherID)
                .Select(x => new
                {
                    x.TeacherID,
                    x.TeacherCode,
                    x.FullName,
                    x.Email,
                    x.Phone,
                    x.DepartmentID,
                    x.Gender,
                    x.Degree,
                    x.Title
                })
                .ToList();

            _selectedTeacherId = null;
            dgvGiangVien.ClearSelection();
        }

        private void DgvGiangVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGiangVien.CurrentRow == null)
            {
                return;
            }

            if (dgvGiangVien.CurrentRow.Cells["TeacherID"].Value == null)
            {
                return;
            }

            _selectedTeacherId = Convert.ToInt32(dgvGiangVien.CurrentRow.Cells["TeacherID"].Value);

            txtMaGV.Text = Convert.ToString(dgvGiangVien.CurrentRow.Cells["TeacherCode"].Value);
            txtHoTen.Text = Convert.ToString(dgvGiangVien.CurrentRow.Cells["FullName"].Value);
            txtEmail.Text = Convert.ToString(dgvGiangVien.CurrentRow.Cells["Email"].Value);
            txtDienThoai.Text = Convert.ToString(dgvGiangVien.CurrentRow.Cells["Phone"].Value);
            txtKhoa.Text = Convert.ToString(dgvGiangVien.CurrentRow.Cells["DepartmentID"].Value);
            cboGioiTinh.Text = Convert.ToString(dgvGiangVien.CurrentRow.Cells["Gender"].Value);
            cboHocVi.Text = Convert.ToString(dgvGiangVien.CurrentRow.Cells["Degree"].Value);
            cboChucDanh.Text = Convert.ToString(dgvGiangVien.CurrentRow.Cells["Title"].Value);
        }

        private bool ValidateInput(out int? departmentId)
        {
            departmentId = null;

            if (string.IsNullOrWhiteSpace(txtMaGV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã giảng viên và họ tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (!string.IsNullOrWhiteSpace(txtKhoa.Text.Trim()) && !int.TryParse(txtKhoa.Text.Trim(), out var parsedDepartmentId))
            {
                MessageBox.Show("Mã khoa phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoa.Focus();
                return false;
            }

            if (int.TryParse(txtKhoa.Text.Trim(), out var departmentIdValue))
            {
                departmentId = departmentIdValue;
            }

            return true;
        }

        private void ClearInput()
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtDienThoai.Clear();
            txtKhoa.Clear();
            cboGioiTinh.SelectedIndex = 0;
            cboHocVi.SelectedIndex = 0;
            cboChucDanh.SelectedIndex = 0;
            _selectedTeacherId = null;
        }

        private void TxtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
