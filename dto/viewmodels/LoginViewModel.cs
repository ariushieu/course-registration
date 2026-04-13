namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho đăng nhập
    /// </summary>
    public class LoginViewModel
    {
        public int AccountID { get; set; }
        public string Username { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int? TeacherID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        
        // Helper properties
        public bool IsAdmin => RoleName == "Admin";
        public bool IsPhongDaoTao => RoleName == "PhongDaoTao";
        public bool IsGiangVien => RoleName == "GiangVien";
    }
}
