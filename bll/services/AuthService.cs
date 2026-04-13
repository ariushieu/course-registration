using System;
using CourseRegistration.DAL.Repositories;
using CourseRegistration.DTO.Entities;
using CourseRegistration.DTO.ViewModels;

namespace CourseRegistration.BLL.Services
{
    /// <summary>
    /// Service xử lý logic xác thực và đăng nhập
    /// </summary>
    public class AuthService
    {
        private readonly AccountRepository _accountRepository;

        public AuthService()
        {
            _accountRepository = new AccountRepository();
        }

        /// <summary>
        /// Đăng nhập
        /// </summary>
        public LoginViewModel Login(string username, string password)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
            }

            // Lấy thông tin account
            Account account = _accountRepository.GetByUsername(username);

            if (account == null)
            {
                throw new Exception("Tên đăng nhập không tồn tại!");
            }

            // Kiểm tra tài khoản có bị khóa không
            if (!account.IsActive)
            {
                throw new Exception("Tài khoản đã bị khóa! Vui lòng liên hệ quản trị viên.");
            }

            // Kiểm tra mật khẩu
            // TODO: Trong thực tế nên dùng hash (BCrypt, SHA256)
            if (account.Password != password)
            {
                throw new Exception("Mật khẩu không đúng!");
            }

            // Cập nhật thời gian đăng nhập cuối
            _accountRepository.UpdateLastLogin(account.AccountID);

            // Tạo LoginViewModel để trả về
            LoginViewModel loginViewModel = new LoginViewModel
            {
                AccountID = account.AccountID,
                Username = account.Username,
                RoleID = account.RoleID,
                RoleName = account.Role.RoleName
            };

            // Nếu là giảng viên, lấy thêm thông tin giảng viên
            if (account.Role.RoleName == "GiangVien")
            {
                // TODO: Lấy thông tin giảng viên từ TeacherRepository
                // loginViewModel.TeacherID = teacher.TeacherID;
                // loginViewModel.FullName = teacher.FullName;
                // loginViewModel.Email = teacher.Email;
            }

            return loginViewModel;
        }

        /// <summary>
        /// Đổi mật khẩu
        /// </summary>
        public bool ChangePassword(int accountId, string oldPassword, string newPassword)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword))
            {
                throw new Exception("Vui lòng nhập đầy đủ mật khẩu cũ và mật khẩu mới!");
            }

            if (newPassword.Length < 6)
            {
                throw new Exception("Mật khẩu mới phải có ít nhất 6 ký tự!");
            }

            // Lấy thông tin account
            Account account = _accountRepository.GetById(accountId);

            if (account == null)
            {
                throw new Exception("Tài khoản không tồn tại!");
            }

            // Kiểm tra mật khẩu cũ
            if (account.Password != oldPassword)
            {
                throw new Exception("Mật khẩu cũ không đúng!");
            }

            // Cập nhật mật khẩu mới
            account.Password = newPassword; // TODO: Hash password
            return _accountRepository.Update(account);
        }
    }
}
