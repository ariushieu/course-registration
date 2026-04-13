using System;
using System.Windows.Forms;

namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    /// <summary>
    /// Form quản lý thông tin các Khoa
    /// </summary>
    public partial class QLKhoa : Form
    {
        public QLKhoa()
        {
            InitializeComponent();
        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            // TODO: Load danh sách khoa từ database
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // TODO: Thêm khoa mới
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // TODO: Sửa thông tin khoa
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // TODO: Xóa khoa
        }
    }
}
