using System;
using System.Windows.Forms;

namespace CourseRegistration.UI.Forms.PhongDaoTao
{
    /// <summary>
    /// Form quản lý thông tin Giảng viên
    /// </summary>
    public partial class QLGiangVien : Form
    {
        public QLGiangVien()
        {
            InitializeComponent();
        }

        private void QLGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: Load danh sách giảng viên từ database
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // TODO: Thêm giảng viên mới
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // TODO: Sửa thông tin giảng viên
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // TODO: Xóa giảng viên
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // TODO: Tìm kiếm giảng viên
        }
    }
}
