using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseRegistration.UI.Forms.PhongDaoTao;

namespace CourseRegistration.UI.UserControls
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            // ApplyCustomColorTable(); // Loại bỏ vì không dùng MenuStrip
            HideAllSubMenus();
            InitializeFeatureNavigation();
        }

        private void InitializeFeatureNavigation()
        {
            btnKhoa.Click += (s, e) => OpenFeatureForm(new QLKhoa());
            btnMonHoc.Click += (s, e) => OpenFeatureForm(new QLMonHoc());
            btnSinhVien.Click += (s, e) => OpenFeatureForm(new QLSinhVien());
            btnGiangVien.Click += (s, e) => OpenFeatureForm(new QLGiangVien());
            btnLopHocPhan.Click += (s, e) => OpenFeatureForm(new QLHocPhan());
        }

        private void OpenFeatureForm(Form form)
        {
            using (form)
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }

        /* 
        // Đã comment lại đoạn code bị lỗi vì menuStrip1 không tồn tại
        private void ApplyCustomColorTable()
        {
            // Thiết lập Custom Renderer để khi hover (chỉ chuột) hoặc click không bị đổi thành màu xanh nhạt khó nhìn
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
        }
        */

        private void HideAllSubMenus()
        {
            // Ẩn tất cả các mục con khi khởi động
            btnDangNhap.Visible = false;
            btnDoiMatKhau.Visible = false;
            btnThietLap.Visible = false;

            btnKhoa.Visible = false;
            btnMonHoc.Visible = false;
            btnPhongHoc.Visible = false;

            btnSinhVien.Visible = false;
            btnGiangVien.Visible = false;

            btnLopHocPhan.Visible = false;
            btnTKB.Visible = false;

            btnDangKy.Visible = false;
            btnXemTKB.Visible = false;

            btnBaoCaoDS.Visible = false;
            btnXuatExcel.Visible = false;
        }

        // --- CÁC HÀM XỬ LÝ SỰ KIỆN CLICK MENU CHÍNH ---
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            bool isExpanded = btnDangNhap.Visible;
            HideAllSubMenus(); // Đóng các menu khác nếu muốn
            
            // Toggle việc hiển thị
            btnDangNhap.Visible = !isExpanded;
            btnDoiMatKhau.Visible = !isExpanded;
            btnThietLap.Visible = !isExpanded;
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            bool isExpanded = btnKhoa.Visible;
            HideAllSubMenus();
            
            btnKhoa.Visible = !isExpanded;
            btnMonHoc.Visible = !isExpanded;
            btnPhongHoc.Visible = !isExpanded;
        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            bool isExpanded = btnSinhVien.Visible;
            HideAllSubMenus();

            btnSinhVien.Visible = !isExpanded;
            btnGiangVien.Visible = !isExpanded;
        }

        private void btnDaoTao_Click(object sender, EventArgs e)
        {
            bool isExpanded = btnLopHocPhan.Visible;
            HideAllSubMenus();

            btnLopHocPhan.Visible = !isExpanded;
            btnTKB.Visible = !isExpanded;
        }

        private void btnNghiepVu_Click(object sender, EventArgs e)
        {
            bool isExpanded = btnDangKy.Visible;
            HideAllSubMenus();

            btnDangKy.Visible = !isExpanded;
            btnXemTKB.Visible = !isExpanded;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            bool isExpanded = btnBaoCaoDS.Visible;
            HideAllSubMenus();

            btnBaoCaoDS.Visible = !isExpanded;
            btnXuatExcel.Visible = !isExpanded;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }
    }

    // Lớp tùy chỉnh màu sắc cho MenuStrip
    public class MenuColorTable : ProfessionalColorTable
    {
        // Loại bỏ đường viền màu trắng của các item sổ xuống
        public override Color ImageMarginGradientBegin => Color.FromArgb(28, 42, 79);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(28, 42, 79);
        public override Color ImageMarginGradientEnd => Color.FromArgb(28, 42, 79);

        // Đổi màu nền khi dùng chuột hover
        public override Color MenuItemSelected => Color.FromArgb(40, 60, 100);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(40, 60, 100);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(40, 60, 100);

        // Đổi màu nền khi bấm vào
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(28, 42, 79);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(28, 42, 79);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(28, 42, 79);

        // Đổi màu viền chọn
        public override Color MenuItemBorder => Color.FromArgb(40, 60, 100);
    }
}
