using System;
using System.Windows.Forms;
using CourseRegistration.BLL.Services;
using CourseRegistration.DAL.Data;
using CourseRegistration.DTO.ViewModels;
using CourseRegistration.UI.UserControls;

namespace CourseRegistration
{
    public partial class Login : Form
    {
        private readonly AuthService _authService;

        public Login()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Kiểm tra kết nối database
            bool isConnected = DbConnection.TestConnection();

            if (!isConnected)
            {
                MessageBox.Show(
                    "Không thể kết nối đến database!\nVui lòng kiểm tra connection string trong App.config",
                    "Lỗi kết nối",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            // Set focus vào textbox username
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin đăng nhập
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;

                // Hiển thị loading
                btnLogin.Enabled = false;
                btnLogin.Text = "Đang đăng nhập...";
                Cursor = Cursors.WaitCursor;

                // Gọi service đăng nhập
                LoginViewModel loginResult = _authService.Login(username, password);

                // Đăng nhập thành công
                MessageBox.Show(
                    $"Đăng nhập thành công!\nXin chào {loginResult.RoleName}!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Lưu thông tin đăng nhập vào session (static class)
                SessionManager.CurrentUser = loginResult;

                // Mở form Menu và ẩn form Login
                UI.UserControls.Menu menuForm = new UI.UserControls.Menu();
                menuForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Lỗi đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                // Reset button
                btnLogin.Enabled = true;
                btnLogin.Text = "Đăng nhập";
                Cursor = Cursors.Default;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nhấn Enter để đăng nhập
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Nhấn Enter để chuyển sang password
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Hiển thị/ẩn mật khẩu
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
    }

    /// <summary>
    /// Class quản lý session người dùng hiện tại
    /// </summary>
    public static class SessionManager
    {
        public static LoginViewModel CurrentUser { get; set; }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
