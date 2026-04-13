# DATABASE DOCUMENTATION

## Tổng quan

Database **CourseRegistrationDB** được thiết kế cho hệ thống quản lý đào tạo nội bộ trường đại học.

---

## Cấu trúc Database

### 📊 Tổng số bảng: 10

1. **Role** - Vai trò người dùng
2. **Account** - Tài khoản đăng nhập
3. **Department** - Khoa
4. **Teacher** - Giảng viên
5. **Course** - Học phần (Môn học)
6. **Semester** - Học kỳ
7. **Classroom** - Phòng học
8. **CourseClass** - Lớp học phần
9. **Schedule** - Thời khóa biểu
10. **AuditLog** - Nhật ký hệ thống

---

## Hướng dẫn cài đặt

### Bước 1: Tạo Database và Tables

```sql
-- Chạy file này trước
sqlcmd -S localhost -i CreateDatabase.sql
```

Hoặc mở SQL Server Management Studio (SSMS) và chạy file `CreateDatabase.sql`

### Bước 2: Insert dữ liệu mẫu

```sql
-- Chạy file này sau
sqlcmd -S localhost -i InsertSampleData.sql
```

Hoặc chạy file `InsertSampleData.sql` trong SSMS

### Bước 3: Tạo Stored Procedures

```sql
-- Chạy file này cuối cùng
sqlcmd -S localhost -i StoredProcedures.sql
```

Hoặc chạy file `StoredProcedures.sql` trong SSMS

---

## Tài khoản mẫu

Sau khi chạy script insert dữ liệu, bạn có thể đăng nhập với các tài khoản sau:

| Username | Password | Role        | Mô tả                    |
| -------- | -------- | ----------- | ------------------------ |
| admin    | 123456   | Admin       | Quản trị hệ thống        |
| daotao01 | 123456   | PhongDaoTao | Nhân viên phòng đào tạo  |
| daotao02 | 123456   | PhongDaoTao | Nhân viên phòng đào tạo  |
| gv001    | 123456   | GiangVien   | Giảng viên Nguyễn Văn An |
| gv002    | 123456   | GiangVien   | Giảng viên Trần Thị Bình |
| gv003    | 123456   | GiangVien   | Giảng viên Lê Văn Cường  |

⚠️ **Lưu ý**: Trong môi trường production, cần mã hóa password bằng hash (MD5, SHA256, BCrypt, ...)

---

## Mô tả chi tiết các bảng

### 1. Role (Vai trò)

Lưu trữ các vai trò trong hệ thống.

| Cột         | Kiểu          | Mô tả                                       |
| ----------- | ------------- | ------------------------------------------- |
| RoleID      | INT (PK)      | ID vai trò                                  |
| RoleName    | NVARCHAR(50)  | Tên vai trò (Admin, PhongDaoTao, GiangVien) |
| Description | NVARCHAR(255) | Mô tả vai trò                               |

### 2. Account (Tài khoản)

Lưu trữ thông tin đăng nhập.

| Cột       | Kiểu          | Mô tả                  |
| --------- | ------------- | ---------------------- |
| AccountID | INT (PK)      | ID tài khoản           |
| Username  | NVARCHAR(50)  | Tên đăng nhập (unique) |
| Password  | NVARCHAR(255) | Mật khẩu (nên hash)    |
| RoleID    | INT (FK)      | ID vai trò             |
| IsActive  | BIT           | Trạng thái hoạt động   |
| LastLogin | DATETIME      | Lần đăng nhập cuối     |

### 3. Department (Khoa)

Lưu trữ thông tin các khoa.

| Cột            | Kiểu          | Mô tả            |
| -------------- | ------------- | ---------------- |
| DepartmentID   | INT (PK)      | ID khoa          |
| DepartmentCode | NVARCHAR(20)  | Mã khoa (unique) |
| DepartmentName | NVARCHAR(255) | Tên khoa         |
| PhoneNumber    | NVARCHAR(20)  | Số điện thoại    |
| Email          | NVARCHAR(100) | Email khoa       |

### 4. Teacher (Giảng viên)

Lưu trữ thông tin giảng viên.

| Cột          | Kiểu          | Mô tả                           |
| ------------ | ------------- | ------------------------------- |
| TeacherID    | INT (PK)      | ID giảng viên                   |
| AccountID    | INT (FK)      | ID tài khoản (1:1)              |
| TeacherCode  | NVARCHAR(20)  | Mã giảng viên (unique)          |
| FullName     | NVARCHAR(100) | Họ tên                          |
| Email        | NVARCHAR(100) | Email cá nhân                   |
| Phone        | NVARCHAR(20)  | Số điện thoại                   |
| DepartmentID | INT (FK)      | ID khoa                         |
| Degree       | NVARCHAR(50)  | Học vị (Thạc sĩ, Tiến sĩ)       |
| Title        | NVARCHAR(50)  | Chức danh (Giảng viên, PGS, GS) |

### 5. Course (Học phần)

Lưu trữ thông tin các học phần/môn học.

| Cột                  | Kiểu          | Mô tả                |
| -------------------- | ------------- | -------------------- |
| CourseID             | INT (PK)      | ID học phần          |
| CourseCode           | NVARCHAR(20)  | Mã học phần (unique) |
| CourseName           | NVARCHAR(255) | Tên học phần         |
| Credits              | INT           | Số tín chỉ           |
| DepartmentID         | INT (FK)      | ID khoa              |
| TheoryHours          | INT           | Số tiết lý thuyết    |
| PracticeHours        | INT           | Số tiết thực hành    |
| PrerequisiteCourseID | INT (FK)      | ID môn tiên quyết    |

### 6. Semester (Học kỳ)

Lưu trữ thông tin các học kỳ.

| Cột          | Kiểu          | Mô tả              |
| ------------ | ------------- | ------------------ |
| SemesterID   | INT (PK)      | ID học kỳ          |
| SemesterCode | NVARCHAR(20)  | Mã học kỳ (unique) |
| SemesterName | NVARCHAR(100) | Tên học kỳ         |
| StartDate    | DATE          | Ngày bắt đầu       |
| EndDate      | DATE          | Ngày kết thúc      |
| IsActive     | BIT           | Học kỳ hiện tại    |

### 7. Classroom (Phòng học)

Lưu trữ thông tin phòng học.

| Cột           | Kiểu          | Mô tả             |
| ------------- | ------------- | ----------------- |
| ClassroomID   | INT (PK)      | ID phòng học      |
| ClassroomCode | NVARCHAR(20)  | Mã phòng (unique) |
| ClassroomName | NVARCHAR(100) | Tên phòng         |
| Building      | NVARCHAR(50)  | Tòa nhà           |
| Floor         | INT           | Tầng              |
| Capacity      | INT           | Sức chứa          |
| RoomType      | NVARCHAR(50)  | Loại phòng        |
| Equipment     | NVARCHAR(500) | Thiết bị          |

### 8. CourseClass (Lớp học phần)

Lưu trữ thông tin các lớp học phần được mở.

| Cột             | Kiểu         | Mô tả                 |
| --------------- | ------------ | --------------------- |
| ClassID         | INT (PK)     | ID lớp học phần       |
| ClassCode       | NVARCHAR(20) | Mã lớp (unique)       |
| CourseID        | INT (FK)     | ID học phần           |
| TeacherID       | INT (FK)     | ID giảng viên         |
| SemesterID      | INT (FK)     | ID học kỳ             |
| MaxStudents     | INT          | Số sinh viên tối đa   |
| CurrentStudents | INT          | Số sinh viên hiện tại |
| Status          | NVARCHAR(20) | Trạng thái lớp        |

### 9. Schedule (Thời khóa biểu)

Lưu trữ lịch học của các lớp.

| Cột         | Kiểu     | Mô tả             |
| ----------- | -------- | ----------------- |
| ScheduleID  | INT (PK) | ID lịch học       |
| ClassID     | INT (FK) | ID lớp học phần   |
| ClassroomID | INT (FK) | ID phòng học      |
| DayOfWeek   | INT      | Thứ (2-8)         |
| StartTime   | TIME     | Giờ bắt đầu       |
| EndTime     | TIME     | Giờ kết thúc      |
| StartDate   | DATE     | Ngày bắt đầu học  |
| EndDate     | DATE     | Ngày kết thúc học |

### 10. AuditLog (Nhật ký)

Lưu trữ lịch sử thao tác trên hệ thống.

| Cột       | Kiểu          | Mô tả                  |
| --------- | ------------- | ---------------------- |
| LogID     | INT (PK)      | ID log                 |
| AccountID | INT (FK)      | ID tài khoản thực hiện |
| Action    | NVARCHAR(100) | Hành động              |
| TableName | NVARCHAR(50)  | Tên bảng               |
| RecordID  | INT           | ID bản ghi             |
| OldValue  | NVARCHAR(MAX) | Giá trị cũ             |
| NewValue  | NVARCHAR(MAX) | Giá trị mới            |

---

## Stored Procedures

### 1. Kiểm tra trùng lịch

```sql
-- Kiểm tra trùng lịch phòng học
EXEC sp_CheckClassroomConflict @ClassroomID, @DayOfWeek, @StartTime, @EndTime, @StartDate, @EndDate

-- Kiểm tra trùng lịch giảng viên
EXEC sp_CheckTeacherConflict @TeacherID, @DayOfWeek, @StartTime, @EndTime, @StartDate, @EndDate
```

### 2. Lấy thời khóa biểu

```sql
-- TKB theo giảng viên
EXEC sp_GetTeacherSchedule @TeacherID, @SemesterID

-- TKB theo phòng học
EXEC sp_GetClassroomSchedule @ClassroomID, @SemesterID
```

### 3. Báo cáo

```sql
-- Báo cáo khối lượng giảng dạy
EXEC sp_ReportTeachingLoad @SemesterID

-- Báo cáo sử dụng phòng học
EXEC sp_ReportClassroomUsage @SemesterID

-- Thống kê theo khoa
EXEC sp_ReportByDepartment @SemesterID
```

### 4. Tìm kiếm

```sql
-- Tìm kiếm giảng viên
EXEC sp_SearchTeacher @Keyword, @DepartmentID
```

---

## Connection String

Cập nhật connection string trong file `App.config`:

```xml
<connectionStrings>
  <add name="DbConn"
       connectionString="Data Source=localhost;Initial Catalog=CourseRegistrationDB;Integrated Security=True"
       providerName="System.Data.SqlClient"/>
</connectionStrings>
```

Hoặc nếu dùng SQL Authentication:

```xml
<connectionStrings>
  <add name="DbConn"
       connectionString="Data Source=localhost;Initial Catalog=CourseRegistrationDB;User ID=sa;Password=yourpassword"
       providerName="System.Data.SqlClient"/>
</connectionStrings>
```

---

## Lưu ý bảo mật

1. **Mã hóa password**: Sử dụng BCrypt hoặc SHA256 để hash password
2. **SQL Injection**: Luôn dùng parameterized query hoặc stored procedure
3. **Backup**: Thiết lập backup tự động cho database
4. **Quyền truy cập**: Giới hạn quyền truy cập database theo vai trò

---

## Tài liệu tham khảo

- [ERD.md](ERD.md) - Sơ đồ quan hệ chi tiết
- [CreateDatabase.sql](CreateDatabase.sql) - Script tạo database
- [InsertSampleData.sql](InsertSampleData.sql) - Dữ liệu mẫu
- [StoredProcedures.sql](StoredProcedures.sql) - Các stored procedure
