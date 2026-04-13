using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CourseRegistration.DTO.Entities;

namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    /// <summary>
    /// Form quản lý thông tin các Khoa
    /// </summary>
    public partial class QLKhoa : Form
    {
        private readonly List<Department> _departments = new List<Department>();
        private int? _selectedDepartmentId;

        private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        private static readonly Regex PhoneRegex = new Regex(@"^\d{8,11}$", RegexOptions.Compiled);

        private DataGridView dgvKhoa;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private TextBox txtDienThoai;
        private TextBox txtEmail;
        private TextBox txtMoTa;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnLamMoi;

        public QLKhoa()
        {
            InitializeComponent();
        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            SeedData();
            BindGrid(_departments);
            ClearInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            if (_departments.Any(x => x.DepartmentCode.Equals(txtMaKhoa.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã khoa đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _departments.Add(new Department
            {
                DepartmentID = _departments.Count == 0 ? 1 : _departments.Max(x => x.DepartmentID) + 1,
                DepartmentCode = txtMaKhoa.Text.Trim(),
                DepartmentName = txtTenKhoa.Text.Trim(),
                PhoneNumber = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Description = txtMoTa.Text.Trim(),
                CreatedDate = DateTime.Now
            });

            BindGrid(_departments);
            ClearInput();
            txtMaKhoa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedDepartmentId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn khoa cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            var departmentId = _selectedDepartmentId.Value;
            var current = _departments.FirstOrDefault(x => x.DepartmentID == departmentId);
            if (current == null)
            {
                return;
            }

            if (_departments.Any(x => x.DepartmentID != departmentId && x.DepartmentCode.Equals(txtMaKhoa.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã khoa đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            current.DepartmentCode = txtMaKhoa.Text.Trim();
            current.DepartmentName = txtTenKhoa.Text.Trim();
            current.PhoneNumber = txtDienThoai.Text.Trim();
            current.Email = txtEmail.Text.Trim();
            current.Description = txtMoTa.Text.Trim();

            BindGrid(_departments);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedDepartmentId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn khoa cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var current = _departments.FirstOrDefault(x => x.DepartmentID == _selectedDepartmentId.Value);
            if (current == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _departments.Remove(current);
            BindGrid(_departments);
            ClearInput();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                BindGrid(_departments);
                return;
            }

            var filtered = _departments.Where(x =>
                (!string.IsNullOrWhiteSpace(x.DepartmentCode) && x.DepartmentCode.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.DepartmentName) && x.DepartmentName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.PhoneNumber) && x.PhoneNumber.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Email) && x.Email.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.Description) && x.Description.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0));

            BindGrid(filtered);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            BindGrid(_departments);
            ClearInput();
            _selectedDepartmentId = null;
            dgvKhoa.ClearSelection();
            txtMaKhoa.Focus();
        }

        private void InitializeCustomControls()
        {
            var pnlTop = new Panel { Dock = DockStyle.Top, Height = 175 };
            var pnlBottom = new Panel { Dock = DockStyle.Fill };

            txtMaKhoa = new TextBox { Left = 100, Top = 15, Width = 160 };
            txtTenKhoa = new TextBox { Left = 390, Top = 15, Width = 260 };
            txtDienThoai = new TextBox { Left = 100, Top = 50, Width = 160 };
            txtEmail = new TextBox { Left = 390, Top = 50, Width = 260 };
            txtMoTa = new TextBox { Left = 100, Top = 85, Width = 550 };
            txtTimKiem = new TextBox { Left = 100, Top = 120, Width = 550 };
            txtTimKiem.KeyDown += TxtTimKiem_KeyDown;

            btnThem = CreateButton("Thêm", 700, 15, btnThem_Click);
            btnSua = CreateButton("Sửa", 700, 50, btnSua_Click);
            btnXoa = CreateButton("Xóa", 700, 85, btnXoa_Click);
            btnTimKiem = CreateButton("Tìm", 700, 120, btnTimKiem_Click);
            btnLamMoi = CreateButton("Làm mới", 800, 120, btnLamMoi_Click);

            pnlTop.Controls.AddRange(new Control[]
            {
                new Label { Text = "Mã khoa", Left = 20, Top = 18, AutoSize = true }, txtMaKhoa,
                new Label { Text = "Tên khoa", Left = 310, Top = 18, AutoSize = true }, txtTenKhoa,
                new Label { Text = "Điện thoại", Left = 20, Top = 53, AutoSize = true }, txtDienThoai,
                new Label { Text = "Email", Left = 310, Top = 53, AutoSize = true }, txtEmail,
                new Label { Text = "Mô tả", Left = 20, Top = 88, AutoSize = true }, txtMoTa,
                new Label { Text = "Tìm kiếm", Left = 20, Top = 123, AutoSize = true }, txtTimKiem,
                btnThem, btnSua, btnXoa, btnTimKiem, btnLamMoi
            });

            dgvKhoa = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false
            };
            dgvKhoa.SelectionChanged += DgvKhoa_SelectionChanged;

            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn { Name = "DepartmentID", DataPropertyName = "DepartmentID", HeaderText = "ID", Width = 60 });
            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn { Name = "DepartmentCode", DataPropertyName = "DepartmentCode", HeaderText = "Mã khoa", Width = 120 });
            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn { Name = "DepartmentName", DataPropertyName = "DepartmentName", HeaderText = "Tên khoa", Width = 260 });
            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn { Name = "PhoneNumber", DataPropertyName = "PhoneNumber", HeaderText = "Điện thoại", Width = 120 });
            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email", Width = 180 });
            dgvKhoa.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", DataPropertyName = "Description", HeaderText = "Mô tả", Width = 220 });

            pnlBottom.Controls.Add(dgvKhoa);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTop);
        }

        private static Button CreateButton(string text, int left, int top, EventHandler onClick)
        {
            var button = new Button { Text = text, Left = left, Top = top, Width = 90 };
            button.Click += onClick;
            return button;
        }

        private void SeedData()
        {
            if (_departments.Count > 0)
            {
                return;
            }

            _departments.Add(new Department
            {
                DepartmentID = 1,
                DepartmentCode = "CNTT",
                DepartmentName = "Công nghệ thông tin",
                PhoneNumber = "02812345678",
                Email = "cntt@univ.edu.vn",
                Description = "Đào tạo khối ngành CNTT",
                CreatedDate = DateTime.Now
            });

            _departments.Add(new Department
            {
                DepartmentID = 2,
                DepartmentCode = "QTKD",
                DepartmentName = "Quản trị kinh doanh",
                PhoneNumber = "02839876543",
                Email = "qtkd@univ.edu.vn",
                Description = "Đào tạo khối ngành kinh tế và quản trị",
                CreatedDate = DateTime.Now
            });
        }

        private void BindGrid(IEnumerable<Department> source)
        {
            dgvKhoa.DataSource = source
                .OrderBy(x => x.DepartmentID)
                .Select(x => new
            {
                x.DepartmentID,
                x.DepartmentCode,
                x.DepartmentName,
                x.PhoneNumber,
                x.Email,
                x.Description
            }).ToList();

            _selectedDepartmentId = null;
            dgvKhoa.ClearSelection();
        }

        private void DgvKhoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhoa.CurrentRow == null)
            {
                return;
            }

            if (dgvKhoa.CurrentRow.Cells["DepartmentID"].Value == null)
            {
                return;
            }

            _selectedDepartmentId = Convert.ToInt32(dgvKhoa.CurrentRow.Cells["DepartmentID"].Value);

            txtMaKhoa.Text = Convert.ToString(dgvKhoa.CurrentRow.Cells["DepartmentCode"].Value);
            txtTenKhoa.Text = Convert.ToString(dgvKhoa.CurrentRow.Cells["DepartmentName"].Value);
            txtDienThoai.Text = Convert.ToString(dgvKhoa.CurrentRow.Cells["PhoneNumber"].Value);
            txtEmail.Text = Convert.ToString(dgvKhoa.CurrentRow.Cells["Email"].Value);
            txtMoTa.Text = Convert.ToString(dgvKhoa.CurrentRow.Cells["Description"].Value);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text) || string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã khoa và tên khoa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Số điện thoại chỉ gồm 8-11 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Focus();
                return false;
            }

            return true;
        }

        private void ClearInput()
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtMoTa.Clear();
            _selectedDepartmentId = null;
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
