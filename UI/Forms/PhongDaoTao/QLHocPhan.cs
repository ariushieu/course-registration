using System;
using System.Windows.Forms;

namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    /// <summary>
    /// Form quản lý Học phần (Môn học)
    /// </summary>
    public partial class QLHocPhan : Form
    {
        public QLHocPhan()
        {
            InitializeComponent();
        }

        private void QLHocPhan_Load(object sender, EventArgs e)
        {
            // TODO: Load danh sách học phần từ database
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // TODO: Thêm học phần mới
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // TODO: Sửa thông tin học phần
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // TODO: Xóa học phần
        }
    }
}
