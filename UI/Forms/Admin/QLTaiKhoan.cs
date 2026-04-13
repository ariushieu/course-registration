using System;
using System.Windows.Forms;

namespace CourseRegistration.UI.Forms.Admin
{
    /// <summary>
    /// Form quản lý tài khoản người dùng
    /// </summary>
    public partial class QLTaiKhoan : Form
    {
        public QLTaiKhoan()
        {
            InitializeComponent();
        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: Load danh sách tài khoản từ database
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // TODO: Thêm tài khoản mới
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // TODO: Sửa thông tin tài khoản
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // TODO: Xóa tài khoản
        }

        private void btnKhoaMo_Click(object sender, EventArgs e)
        {
            // TODO: Khóa/Mở tài khoản
        }
    }
}
