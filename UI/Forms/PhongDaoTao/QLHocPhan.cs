using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourseRegistration.DTO.Entities;

namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    /// <summary>
    /// Form quản lý Học phần (Môn học)
    /// </summary>
    public partial class QLHocPhan : Form
    {
        private readonly List<Course> _courses = new List<Course>();
        private int? _selectedCourseId;

        private DataGridView dgvHocPhan;
        private TextBox txtMaHP;
        private TextBox txtTenHP;
        private NumericUpDown nudSoTinChi;
        private TextBox txtMaKhoa;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnLamMoi;

        public QLHocPhan()
        {
            InitializeComponent();
        }

        private void QLHocPhan_Load(object sender, EventArgs e)
        {
            SeedData();
            BindGrid(_courses);
            ClearInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out var departmentId))
            {
                return;
            }

            if (_courses.Any(x => x.CourseCode.Equals(txtMaHP.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã học phần đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _courses.Add(new Course
            {
                CourseID = _courses.Count == 0 ? 1 : _courses.Max(x => x.CourseID) + 1,
                CourseCode = txtMaHP.Text.Trim(),
                CourseName = txtTenHP.Text.Trim(),
                Credits = Convert.ToInt32(nudSoTinChi.Value),
                DepartmentID = departmentId,
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            BindGrid(_courses);
            ClearInput();
            txtMaHP.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedCourseId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn học phần cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(out var departmentId))
            {
                return;
            }

            var courseId = _selectedCourseId.Value;
            var current = _courses.FirstOrDefault(x => x.CourseID == courseId);
            if (current == null)
            {
                return;
            }

            if (_courses.Any(x => x.CourseID != courseId && x.CourseCode.Equals(txtMaHP.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã học phần đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            current.CourseCode = txtMaHP.Text.Trim();
            current.CourseName = txtTenHP.Text.Trim();
            current.Credits = Convert.ToInt32(nudSoTinChi.Value);
            current.DepartmentID = departmentId;

            BindGrid(_courses);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedCourseId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn học phần cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var current = _courses.FirstOrDefault(x => x.CourseID == _selectedCourseId.Value);
            if (current == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa học phần này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _courses.Remove(current);
            BindGrid(_courses);
            ClearInput();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.Trim();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                BindGrid(_courses);
                return;
            }

            var filtered = _courses.Where(x =>
                (!string.IsNullOrWhiteSpace(x.CourseCode) && x.CourseCode.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrWhiteSpace(x.CourseName) && x.CourseName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (x.DepartmentID.HasValue && x.DepartmentID.Value.ToString().Contains(keyword)) ||
                x.Credits.ToString().Contains(keyword));

            BindGrid(filtered);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            BindGrid(_courses);
            ClearInput();
            _selectedCourseId = null;
            dgvHocPhan.ClearSelection();
            txtMaHP.Focus();
        }

        private void InitializeCustomControls()
        {
            var pnlTop = new Panel { Dock = DockStyle.Top, Height = 145 };
            var pnlBottom = new Panel { Dock = DockStyle.Fill };

            txtMaHP = new TextBox { Left = 100, Top = 15, Width = 180 };
            txtTenHP = new TextBox { Left = 420, Top = 15, Width = 260 };
            nudSoTinChi = new NumericUpDown { Left = 100, Top = 50, Width = 80, Minimum = 1, Maximum = 10, Value = 3 };
            txtMaKhoa = new TextBox { Left = 420, Top = 50, Width = 120 };
            txtTimKiem = new TextBox { Left = 420, Top = 85, Width = 260 };
            txtTimKiem.KeyDown += TxtTimKiem_KeyDown;

            btnThem = CreateButton("Thêm", 700, 12, btnThem_Click);
            btnSua = CreateButton("Sửa", 700, 42, btnSua_Click);
            btnXoa = CreateButton("Xóa", 700, 72, btnXoa_Click);
            btnTimKiem = CreateButton("Tìm", 700, 102, btnTimKiem_Click);
            btnLamMoi = CreateButton("Làm mới", 800, 102, btnLamMoi_Click);

            pnlTop.Controls.AddRange(new Control[]
            {
                new Label { Text = "Mã HP", Left = 20, Top = 18, AutoSize = true }, txtMaHP,
                new Label { Text = "Tên học phần", Left = 320, Top = 18, AutoSize = true }, txtTenHP,
                new Label { Text = "Số tín chỉ", Left = 20, Top = 53, AutoSize = true }, nudSoTinChi,
                new Label { Text = "Mã khoa", Left = 320, Top = 53, AutoSize = true }, txtMaKhoa,
                new Label { Text = "Tìm kiếm", Left = 320, Top = 88, AutoSize = true }, txtTimKiem,
                btnThem, btnSua, btnXoa, btnTimKiem, btnLamMoi
            });

            dgvHocPhan = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false
            };
            dgvHocPhan.SelectionChanged += DgvHocPhan_SelectionChanged;

            dgvHocPhan.Columns.Add(new DataGridViewTextBoxColumn { Name = "CourseID", DataPropertyName = "CourseID", HeaderText = "ID", Width = 60 });
            dgvHocPhan.Columns.Add(new DataGridViewTextBoxColumn { Name = "CourseCode", DataPropertyName = "CourseCode", HeaderText = "Mã HP", Width = 120 });
            dgvHocPhan.Columns.Add(new DataGridViewTextBoxColumn { Name = "CourseName", DataPropertyName = "CourseName", HeaderText = "Tên học phần", Width = 280 });
            dgvHocPhan.Columns.Add(new DataGridViewTextBoxColumn { Name = "Credits", DataPropertyName = "Credits", HeaderText = "Số tín chỉ", Width = 90 });
            dgvHocPhan.Columns.Add(new DataGridViewTextBoxColumn { Name = "DepartmentID", DataPropertyName = "DepartmentID", HeaderText = "Mã khoa", Width = 90 });

            pnlBottom.Controls.Add(dgvHocPhan);
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
            if (_courses.Count > 0)
            {
                return;
            }

            _courses.Add(new Course
            {
                CourseID = 1,
                CourseCode = "HP001",
                CourseName = "Lập trình hướng đối tượng",
                Credits = 3,
                DepartmentID = 1,
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            _courses.Add(new Course
            {
                CourseID = 2,
                CourseCode = "HP002",
                CourseName = "Cơ sở dữ liệu",
                Credits = 3,
                DepartmentID = 1,
                IsActive = true,
                CreatedDate = DateTime.Now
            });
        }

        private void BindGrid(IEnumerable<Course> source)
        {
            dgvHocPhan.DataSource = source
                .OrderBy(x => x.CourseID)
                .Select(x => new
            {
                x.CourseID,
                x.CourseCode,
                x.CourseName,
                x.Credits,
                x.DepartmentID
            }).ToList();

            _selectedCourseId = null;
            dgvHocPhan.ClearSelection();
        }

        private void DgvHocPhan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocPhan.CurrentRow == null)
            {
                return;
            }

            if (dgvHocPhan.CurrentRow.Cells["CourseID"].Value == null)
            {
                return;
            }

            _selectedCourseId = Convert.ToInt32(dgvHocPhan.CurrentRow.Cells["CourseID"].Value);

            txtMaHP.Text = Convert.ToString(dgvHocPhan.CurrentRow.Cells["CourseCode"].Value);
            txtTenHP.Text = Convert.ToString(dgvHocPhan.CurrentRow.Cells["CourseName"].Value);
            nudSoTinChi.Value = Convert.ToDecimal(dgvHocPhan.CurrentRow.Cells["Credits"].Value);
            txtMaKhoa.Text = Convert.ToString(dgvHocPhan.CurrentRow.Cells["DepartmentID"].Value);
        }

        private bool ValidateInput(out int? departmentId)
        {
            departmentId = null;

            if (string.IsNullOrWhiteSpace(txtMaHP.Text) || string.IsNullOrWhiteSpace(txtTenHP.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã và tên học phần.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var departmentText = txtMaKhoa.Text.Trim();
            if (!string.IsNullOrWhiteSpace(departmentText) && !int.TryParse(departmentText, out var parsedDepartmentId))
            {
                MessageBox.Show("Mã khoa phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                return false;
            }

            if (int.TryParse(departmentText, out var value))
            {
                departmentId = value;
            }

            return true;
        }

        private void ClearInput()
        {
            txtMaHP.Clear();
            txtTenHP.Clear();
            txtMaKhoa.Clear();
            nudSoTinChi.Value = 3;
            _selectedCourseId = null;
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
