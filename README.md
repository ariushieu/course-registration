# HỆ THỐNG QUẢN LÝ ĐÀO TẠO TRƯỜNG ĐẠI HỌC

**Đề tài:** Xây dựng ứng dụng WinForm quản lý nội bộ hệ thống đào tạo của trường đại học.

## Mô tả hệ thống:

Hệ thống quản lý đào tạo là ứng dụng dành cho các bộ phận quản lý nội bộ của trường đại học, bao gồm: Admin, Phòng Đào Tạo, Giảng viên. Hệ thống hỗ trợ quản lý toàn bộ quy trình đào tạo từ quản lý danh mục, lập kế hoạch giảng dạy, đến thống kê báo cáo.

---

## Các phân hệ chính:

### 1. Phân hệ Admin (Quản trị hệ thống)

- **Quản lý tài khoản:** Tạo, phân quyền, khóa/mở tài khoản cho các bộ phận.
- **Quản lý danh mục hệ thống:** Cấu hình các tham số chung của hệ thống.
- **Phân quyền:** Thiết lập quyền truy cập cho từng vai trò (Admin, Phòng Đào Tạo, Giảng viên).
- **Giám sát hệ thống:** Theo dõi hoạt động, log hệ thống.

### 2. Phân hệ Phòng Đào Tạo

- **Quản lý Khoa:** Thêm, sửa, xóa, tìm kiếm thông tin các Khoa.
- **Quản lý Học phần:** Quản lý danh mục các học phần (môn học), điều kiện tiên quyết.
- **Quản lý Giảng viên:** Thêm, sửa, xóa thông tin giảng viên, phân công giảng dạy.
- **Quản lý Phòng học:** Quản lý danh sách phòng học, sức chứa, thiết bị.
- **Quản lý Lớp học phần:** Mở lớp học phần cho từng học kỳ, phân công giảng viên, quy định số lượng sinh viên tối đa.
- **Quản lý Thời khóa biểu:** Sắp xếp lịch học, phòng học cho các lớp học phần, kiểm tra trùng lịch.
- **Thống kê & Báo cáo:**
  - Xuất danh sách lớp học phần theo học kỳ
  - Thống kê số lượng lớp, giảng viên, phòng học
  - Báo cáo tình hình sử dụng phòng học
  - Báo cáo khối lượng giảng dạy của giảng viên

### 3. Phân hệ Giảng viên

- **Xem thông tin cá nhân:** Xem và cập nhật thông tin cá nhân.
- **Xem lịch giảng dạy:** Xem thời khóa biểu các lớp được phân công.
- **Quản lý lớp học phần:** Xem danh sách sinh viên trong lớp được phân công.
- **Nhập điểm:** Nhập điểm cho sinh viên (nếu có chức năng mở rộng).
- **Báo cáo:** Xem báo cáo khối lượng giảng dạy cá nhân.

---

## Cấu trúc dự án:

```text
CourseRegistration/
├── DTO/ (Data Transfer Objects)
│   ├── Entities/              # Các entity ánh xạ 1-1 với database
│   │   ├── Account.cs         # Tài khoản người dùng
│   │   ├── Teacher.cs         # Giảng viên
│   │   ├── Department.cs      # Khoa
│   │   ├── Course.cs          # Học phần (môn học)
│   │   ├── Classroom.cs       # Phòng học
│   │   ├── CourseClass.cs     # Lớp học phần
│   │   ├── Schedule.cs        # Thời khóa biểu
│   │   └── Semester.cs        # Học kỳ
│   └── ViewModels/            # Các ViewModel cho hiển thị
│       ├── CourseClassViewModel.cs
│       ├── ScheduleViewModel.cs
│       └── TeacherViewModel.cs
│
├── DAL/ (Data Access Layer)
│   ├── Data/
│   │   └── DbConnection.cs    # Quản lý kết nối database
│   ├── Interfaces/            # Các interface cho Repository pattern
│   │   ├── IAccountRepository.cs
│   │   ├── ITeacherRepository.cs
│   │   ├── IDepartmentRepository.cs
│   │   ├── ICourseRepository.cs
│   │   ├── IClassroomRepository.cs
│   │   └── IScheduleRepository.cs
│   └── Repositories/          # Implement các Repository
│       ├── AccountRepository.cs
│       ├── TeacherRepository.cs
│       ├── DepartmentRepository.cs
│       ├── CourseRepository.cs
│       ├── ClassroomRepository.cs
│       └── ScheduleRepository.cs
│
├── BLL/ (Business Logic Layer)
│   ├── Services/              # Các service xử lý logic nghiệp vụ
│   │   ├── AuthService.cs     # Xác thực, phân quyền
│   │   ├── TeacherService.cs  # Logic quản lý giảng viên
│   │   ├── DepartmentService.cs
│   │   ├── CourseService.cs
│   │   ├── ClassroomService.cs
│   │   ├── ScheduleService.cs # Logic sắp xếp TKB, check trùng lịch
│   │   └── ReportService.cs   # Logic xuất báo cáo
│   └── Validations/           # Validation cho input
│       ├── AccountValidator.cs
│       ├── TeacherValidator.cs
│       └── ScheduleValidator.cs
│
└── UI/ (Presentation Layer - WinForms)
    ├── Forms/
    │   ├── Login.cs           # Form đăng nhập
    │   ├── Admin/             # Các form dành cho Admin
    │   │   ├── QLTaiKhoan.cs
    │   │   ├── QLPhanQuyen.cs
    │   │   └── CauHinhHeThong.cs
    │   ├── PhongDaoTao/       # Các form dành cho Phòng Đào Tạo
    │   │   ├── QLKhoa.cs
    │   │   ├── QLHocPhan.cs
    │   │   ├── QLGiangVien.cs
    │   │   ├── QLPhongHoc.cs
    │   │   ├── QLLopHocPhan.cs
    │   │   ├── QLTKB.cs
    │   │   └── XuatBaoCao.cs
    │   └── Teacher/           # Các form dành cho Giảng viên
    │       ├── XemThongTinCaNhan.cs
    │       ├── XemLichGiangDay.cs
    │       ├── XemDanhSachLop.cs
    │       └── XemBaoCaoGiangDay.cs
    ├── UserControls/          # Các control dùng chung
    │   ├── Menu.cs            # Menu điều hướng
    │   └── Header.cs          # Header hiển thị thông tin user
    ├── Utils/                 # Các helper class
    │   ├── FormHelper.cs      # Hỗ trợ chuyển form
    │   ├── ValidationHelper.cs
    │   └── ExportHelper.cs    # Hỗ trợ xuất Excel, PDF
    └── Program.cs             # Entry point

```

---

## Công nghệ sử dụng:

- **Framework:** .NET Framework 4.7.2
- **UI:** Windows Forms
- **Database:** SQL Server
- **Architecture:** 3-Layer Architecture (DAL - BLL - UI)
- **Pattern:** Repository Pattern, Service Pattern

---

## Tính năng nổi bật:

1. **Quản lý tập trung:** Tất cả thông tin đào tạo được quản lý tập trung tại một hệ thống.
2. **Phân quyền rõ ràng:** Mỗi vai trò có quyền truy cập và chức năng riêng biệt.
3. **Kiểm tra tự động:** Hệ thống tự động kiểm tra trùng lịch khi sắp xếp thời khóa biểu.
4. **Báo cáo đa dạng:** Hỗ trợ xuất nhiều loại báo cáo phục vụ công tác quản lý.
5. **Giao diện thân thiện:** Thiết kế giao diện đơn giản, dễ sử dụng.

---

## Hướng dẫn cài đặt:

1. Clone repository về máy
2. Mở file `CourseRegistration.sln` bằng Visual Studio
3. Cấu hình connection string trong `App.config`
4. Chạy script tạo database (nếu có)
5. Build và chạy project

---

## Tác giả:

Bài tập lớn môn Công nghệ .NET

---

## Ghi chú:

- Hệ thống đang trong quá trình phát triển
- Một số tính năng có thể chưa hoàn thiện
- Liên hệ để được hỗ trợ khi gặp vấn đề
