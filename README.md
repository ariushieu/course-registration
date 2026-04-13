# BÀI TẬP LỚN MÔN CÔNG NGHỆ .NET

**Đề tài:** Xây dựng ứng dụng WinForm quản lý đăng ký học phần của sinh viên.

## Case (dự kiến):

### Phân hệ Admin (Nhân viên phòng đào tạo)
- **Quản lý Danh mục:** Thêm, sửa, xóa, tìm kiếm Sinh viên, Giảng viên, Khoa, Môn học.
- **Quản lý Lớp học phần:** Mở các lớp học cho từng học kỳ, quy định số lượng sinh viên tối đa.
- **Quản lý Thời khóa biểu:** Sắp xếp lịch học, phòng học cho các lớp học phần.
- **Thống kê & Báo cáo:** Xuất danh sách sinh viên theo lớp, thống kê số lượng đăng ký.

### Phân hệ Sinh viên
- **Tra cứu thông tin:** Xem danh sách môn học mở trong kỳ.
- **Đăng ký học phần:** Chọn lớp học phần, kiểm tra trùng lịch, kiểm tra điều kiện (nếu có).
- **Hủy đăng ký:** Cho phép hủy trong thời gian quy định.
- **Xem lịch học cá nhân:** Xem thời khóa biểu các môn đã đăng ký thành công.

## Cấu trúc:

```text
src/
├── CourseRegistration.DTO (Data Transfer Objects / Entities)
│   ├── Entities/ (1-1 với database, nghĩa là database có trường nào thì ghi hết)
│   │   ├── Account.cs
│   │   ├── Student.cs
│   │   ├── Course.cs
│   │   └── Registration.cs
│   └── ViewModels/ (Chỉ show những thông tin cần thiết)
│
├── CourseRegistration.DAL (Data Access Layer)
│   ├── Data/
│   │   └── DbConnection.cs (Kết nối db)
│   ├── Repositories/ (Viết logic thêm sửa xóa)
│   │   ├── StudentRepository.cs
│   │   ├── CourseRepository.cs
│   │   └── AccountRepository.cs
│   └── Interfaces/ (cho thằng con trong repository kế thừa)
│
├── CourseRegistration.BLL (Business Logic Layer)
│   ├── Services/ (code logic)
│   │   ├── RegistrationService.cs (Complex logic: check credits, schedule conflict)
│   │   ├── AuthService.cs (Login/Logout logic)
│   │   └── StudentService.cs
│   └── Validations/ (Check input)
│
└── CourseRegistration.UI (Presentation Layer - WinForms Project)
    ├── Forms/
    │   ├── Admin/ (Các form của admin)
    │   │   ├── frmManageCourses.cs
    │   │   └── frmManageStudents.cs
    │   ├── Student/ (Các form của học sinh)
    │   │   ├── frmCourseRegistration.cs
    │   │   └── frmViewSchedule.cs
    │   └── frmLogin.cs (Form đăng nhập, mặc định khi mở ra là nó)
    ├── UserControls/ (Các form dùng chung, ví dụ thanh bar)
    ├── Utils/ (UI helpers: Image scaling, Form transitions)
    └── Program.cs

