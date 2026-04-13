using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourseRegistration.DTO.Entities;

namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    /// <summary>
    /// Form quản lý môn học
    /// </summary>
    public partial class QLMonHoc : Form
    {
        private readonly List<Course> _courses = new List<Course>();
        private int? _selectedCourseId;

        private DataGridView dgvMonHoc;
        private TextBox txtMaMon;
        private TextBox txtTenMon;
        private TextBox txtMaKhoa;
        private TextBox txtMonTienQuyet;
        private TextBox txtMoTa;
        private TextBox txtTimKiem;
        private NumericUpDown nudSoTinChi;
        private NumericUpDown nudTietLyThuyet;
        private NumericUpDown nudTietThucHanh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnLamMoi;

        public QLMonHoc()
        {
            InitializeComponent();
            Load += QLMonHoc_Load;
        }

        private void QLMonHoc_Load(object sender, EventArgs e)
        {
            SeedData();
            BindGrid(_courses);
            ClearInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out var departmentId, out var prerequisiteCourseId, null))
            {
                return;
            }

            if (_courses.Any(x => x.CourseCode.Equals(txtMaMon.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã môn học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _courses.Add(new Course
            {
                CourseID = _courses.Count == 0 ? 1 : _courses.Max(x => x.CourseID) + 1,
                CourseCode = txtMaMon.Text.Trim(),
                CourseName = txtTenMon.Text.Trim(),
                Credits = Convert.ToInt32(nudSoTinChi.Value),
                TheoryHours = Convert.ToInt32(nudTietLyThuyet.Value),
                PracticeHours = Convert.ToInt32(nudTietThucHanh.Value),
                DepartmentID = departmentId,
                PrerequisiteCourseID = prerequisiteCourseId,
                Description = txtMoTa.Text.Trim(),
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            BindGrid(_courses);
            ClearInput();
            txtMaMon.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedCourseId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn môn học cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(out var departmentId, out var prerequisiteCourseId, _selectedCourseId))
            {
                return;
            }

            var course = _courses.FirstOrDefault(x => x.CourseID == _selectedCourseId.Value);
            if (course == null)
            {
                return;
            }

            if (_courses.Any(x => x.CourseID != course.CourseID && x.CourseCode.Equals(txtMaMon.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã môn học đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            course.CourseCode = txtMaMon.Text.Trim();
            course.CourseName = txtTenMon.Text.Trim();
            course.Credits = Convert.ToInt32(nudSoTinChi.Value);
            course.TheoryHours = Convert.ToInt32(nudTietLyThuyet.Value);
            course.PracticeHours = Convert.ToInt32(nudTietThucHanh.Value);
            course.DepartmentID = departmentId;
            course.PrerequisiteCourseID = prerequisiteCourseId;
            course.Description = txtMoTa.Text.Trim();

            BindGrid(_courses);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedCourseId.HasValue)
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var course = _courses.FirstOrDefault(x => x.CourseID == _selectedCourseId.Value);
            if (course == null)
            {
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _courses.Remove(course);
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
                (x.PrerequisiteCourseID.HasValue && x.PrerequisiteCourseID.Value.ToString().Contains(keyword)) ||
                (!string.IsNullOrWhiteSpace(x.Description) && x.Description.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0));

            BindGrid(filtered);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            BindGrid(_courses);
            ClearInput();
            dgvMonHoc.ClearSelection();
            txtMaMon.Focus();
        }

        private void InitializeCustomControls()
        {
            ClientSize = new System.Drawing.Size(1200, 700);
            Text = "Quản lý Môn học";

            var pnlTop = new Panel { Dock = DockStyle.Top, Height = 175 };
            var pnlBottom = new Panel { Dock = DockStyle.Fill };

            txtMaMon = new TextBox { Left = 110, Top = 15, Width = 180 };
            txtTenMon = new TextBox { Left = 450, Top = 15, Width = 300 };
            txtMaKhoa = new TextBox { Left = 910, Top = 15, Width = 140 };

            nudSoTinChi = new NumericUpDown { Left = 110, Top = 50, Width = 80, Minimum = 1, Maximum = 10, Value = 3 };
            nudTietLyThuyet = new NumericUpDown { Left = 450, Top = 50, Width = 90, Minimum = 0, Maximum = 200, Value = 30 };
            nudTietThucHanh = new NumericUpDown { Left = 660, Top = 50, Width = 90, Minimum = 0, Maximum = 200, Value = 15 };
            txtMonTienQuyet = new TextBox { Left = 910, Top = 50, Width = 140 };

            txtMoTa = new TextBox { Left = 110, Top = 85, Width = 640 };
            txtTimKiem = new TextBox { Left = 910, Top = 85, Width = 220 };
            txtTimKiem.KeyDown += TxtTimKiem_KeyDown;

            btnThem = CreateButton("Thêm", 110, 120, btnThem_Click);
            btnSua = CreateButton("Sửa", 210, 120, btnSua_Click);
            btnXoa = CreateButton("Xóa", 310, 120, btnXoa_Click);
            btnTimKiem = CreateButton("Tìm", 910, 120, btnTimKiem_Click);
            btnLamMoi = CreateButton("Làm mới", 1010, 120, btnLamMoi_Click);

            pnlTop.Controls.AddRange(new Control[]
            {
                new Label { Text = "Mã môn", Left = 20, Top = 18, AutoSize = true }, txtMaMon,
                new Label { Text = "Tên môn học", Left = 350, Top = 18, AutoSize = true }, txtTenMon,
                new Label { Text = "Mã khoa", Left = 830, Top = 18, AutoSize = true }, txtMaKhoa,

                new Label { Text = "Số tín chỉ", Left = 20, Top = 53, AutoSize = true }, nudSoTinChi,
                new Label { Text = "Tiết LT", Left = 350, Top = 53, AutoSize = true }, nudTietLyThuyet,
                new Label { Text = "Tiết TH", Left = 580, Top = 53, AutoSize = true }, nudTietThucHanh,
                new Label { Text = "Môn tiên quyết", Left = 800, Top = 53, AutoSize = true }, txtMonTienQuyet,

                new Label { Text = "Mô tả", Left = 20, Top = 88, AutoSize = true }, txtMoTa,
                new Label { Text = "Tìm kiếm", Left = 830, Top = 88, AutoSize = true }, txtTimKiem,

                btnThem, btnSua, btnXoa, btnTimKiem, btnLamMoi
            });

            dgvMonHoc = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false
            };
            dgvMonHoc.SelectionChanged += DgvMonHoc_SelectionChanged;

            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "CourseID", DataPropertyName = "CourseID", HeaderText = "ID", Width = 60 });
            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "CourseCode", DataPropertyName = "CourseCode", HeaderText = "Mã môn", Width = 110 });
            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "CourseName", DataPropertyName = "CourseName", HeaderText = "Tên môn học", Width = 230 });
            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "Credits", DataPropertyName = "Credits", HeaderText = "Tín chỉ", Width = 80 });
            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "TheoryHours", DataPropertyName = "TheoryHours", HeaderText = "Tiết LT", Width = 80 });
            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "PracticeHours", DataPropertyName = "PracticeHours", HeaderText = "Tiết TH", Width = 80 });
            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "DepartmentID", DataPropertyName = "DepartmentID", HeaderText = "Mã khoa", Width = 90 });
            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "PrerequisiteCourseID", DataPropertyName = "PrerequisiteCourseID", HeaderText = "Tiên quyết", Width = 90 });
            dgvMonHoc.Columns.Add(new DataGridViewTextBoxColumn { Name = "Description", DataPropertyName = "Description", HeaderText = "Mô tả", Width = 300 });

            pnlBottom.Controls.Add(dgvMonHoc);
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
            if (_courses.Count > 0)
            {
                return;
            }

            _courses.Add(new Course
            {
                CourseID = 1,
                CourseCode = "MH001",
                CourseName = "Lập trình C#",
                Credits = 3,
                TheoryHours = 30,
                PracticeHours = 15,
                DepartmentID = 1,
                Description = "Môn nền tảng lập trình hướng đối tượng với C#",
                IsActive = true,
                CreatedDate = DateTime.Now
            });

            _courses.Add(new Course
            {
                CourseID = 2,
                CourseCode = "MH002",
                CourseName = "Cấu trúc dữ liệu và giải thuật",
                Credits = 4,
                TheoryHours = 45,
                PracticeHours = 15,
                DepartmentID = 1,
                PrerequisiteCourseID = 1,
                Description = "Môn học về cấu trúc dữ liệu cơ bản và thuật toán",
                IsActive = true,
                CreatedDate = DateTime.Now
            });
        }

        private void BindGrid(IEnumerable<Course> source)
        {
            dgvMonHoc.DataSource = source
                .OrderBy(x => x.CourseID)
                .Select(x => new
                {
                    x.CourseID,
                    x.CourseCode,
                    x.CourseName,
                    x.Credits,
                    x.TheoryHours,
                    x.PracticeHours,
                    x.DepartmentID,
                    x.PrerequisiteCourseID,
                    x.Description
                })
                .ToList();

            _selectedCourseId = null;
            dgvMonHoc.ClearSelection();
        }

        private void DgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMonHoc.CurrentRow == null || dgvMonHoc.CurrentRow.Cells["CourseID"].Value == null)
            {
                return;
            }

            _selectedCourseId = Convert.ToInt32(dgvMonHoc.CurrentRow.Cells["CourseID"].Value);
            txtMaMon.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["CourseCode"].Value);
            txtTenMon.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["CourseName"].Value);
            nudSoTinChi.Value = Convert.ToDecimal(dgvMonHoc.CurrentRow.Cells["Credits"].Value);
            nudTietLyThuyet.Value = Convert.ToDecimal(dgvMonHoc.CurrentRow.Cells["TheoryHours"].Value);
            nudTietThucHanh.Value = Convert.ToDecimal(dgvMonHoc.CurrentRow.Cells["PracticeHours"].Value);
            txtMaKhoa.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["DepartmentID"].Value);
            txtMonTienQuyet.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["PrerequisiteCourseID"].Value);
            txtMoTa.Text = Convert.ToString(dgvMonHoc.CurrentRow.Cells["Description"].Value);
        }

        private bool ValidateInput(out int? departmentId, out int? prerequisiteCourseId, int? currentCourseId)
        {
            departmentId = null;
            prerequisiteCourseId = null;

            if (string.IsNullOrWhiteSpace(txtMaMon.Text) || string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã môn và tên môn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtMaKhoa.Text.Trim()) && !int.TryParse(txtMaKhoa.Text.Trim(), out var parsedDepartmentId))
            {
                MessageBox.Show("Mã khoa phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhoa.Focus();
                return false;
            }

            if (int.TryParse(txtMaKhoa.Text.Trim(), out var departmentValue))
            {
                departmentId = departmentValue;
            }

            if (!string.IsNullOrWhiteSpace(txtMonTienQuyet.Text.Trim()) && !int.TryParse(txtMonTienQuyet.Text.Trim(), out var parsedPrerequisiteId))
            {
                MessageBox.Show("Mã môn tiên quyết phải là số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonTienQuyet.Focus();
                return false;
            }

            if (int.TryParse(txtMonTienQuyet.Text.Trim(), out var prerequisiteValue))
            {
                if (!_courses.Any(x => x.CourseID == prerequisiteValue))
                {
                    MessageBox.Show("Mã môn tiên quyết không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonTienQuyet.Focus();
                    return false;
                }

                if (currentCourseId.HasValue && currentCourseId.Value == prerequisiteValue)
                {
                    MessageBox.Show("Môn học không thể là môn tiên quyết của chính nó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonTienQuyet.Focus();
                    return false;
                }

                prerequisiteCourseId = prerequisiteValue;
            }

            return true;
        }

        private void ClearInput()
        {
            txtMaMon.Clear();
            txtTenMon.Clear();
            txtMaKhoa.Clear();
            txtMonTienQuyet.Clear();
            txtMoTa.Clear();
            nudSoTinChi.Value = 3;
            nudTietLyThuyet.Value = 30;
            nudTietThucHanh.Value = 15;
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
