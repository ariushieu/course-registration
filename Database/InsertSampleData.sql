-- =============================================
-- Script Insert dữ liệu mẫu
-- =============================================

USE CourseRegistrationDB;
GO

-- =============================================
-- 1. INSERT ROLE
-- =============================================
INSERT INTO Role (RoleName, Description) VALUES
(N'Admin', N'Quản trị hệ thống'),
(N'PhongDaoTao', N'Nhân viên phòng đào tạo'),
(N'GiangVien', N'Giảng viên');
GO

-- =============================================
-- 2. INSERT ACCOUNT
-- Password: 123456 (nên mã hóa trong thực tế)
-- =============================================
INSERT INTO Account (Username, Password, RoleID, IsActive) VALUES
('admin', '123456', 1, 1),
('daotao01', '123456', 2, 1),
('daotao02', '123456', 2, 1),
('gv001', '123456', 3, 1),
('gv002', '123456', 3, 1),
('gv003', '123456', 3, 1),
('gv004', '123456', 3, 1),
('gv005', '123456', 3, 1);
GO

-- =============================================
-- 3. INSERT DEPARTMENT
-- =============================================
INSERT INTO Department (DepartmentCode, DepartmentName, Description, FoundedDate, PhoneNumber, Email) VALUES
('CNTT', N'Công nghệ Thông tin', N'Khoa Công nghệ Thông tin', '2000-01-01', '0241234567', 'cntt@university.edu.vn'),
('KTPM', N'Kỹ thuật Phần mềm', N'Khoa Kỹ thuật Phần mềm', '2005-01-01', '0241234568', 'ktpm@university.edu.vn'),
('KHMT', N'Khoa học Máy tính', N'Khoa Khoa học Máy tính', '2000-01-01', '0241234569', 'khmt@university.edu.vn'),
('HTTT', N'Hệ thống Thông tin', N'Khoa Hệ thống Thông tin', '2010-01-01', '0241234570', 'httt@university.edu.vn'),
('ATTT', N'An toàn Thông tin', N'Khoa An toàn Thông tin', '2015-01-01', '0241234571', 'attt@university.edu.vn');
GO

-- =============================================
-- 4. INSERT TEACHER
-- =============================================
INSERT INTO Teacher (AccountID, TeacherCode, FullName, Email, Phone, DepartmentID, DateOfBirth, Gender, Degree, Title, HireDate) VALUES
(4, 'GV001', N'Nguyễn Văn An', 'nva@university.edu.vn', '0901234567', 1, '1980-05-15', N'Nam', N'Tiến sĩ', N'Phó Giáo sư', '2005-09-01'),
(5, 'GV002', N'Trần Thị Bình', 'ttb@university.edu.vn', '0901234568', 1, '1985-08-20', N'Nữ', N'Thạc sĩ', N'Giảng viên', '2010-09-01'),
(6, 'GV003', N'Lê Văn Cường', 'lvc@university.edu.vn', '0901234569', 2, '1982-03-10', N'Nam', N'Tiến sĩ', N'Giảng viên chính', '2008-09-01'),
(7, 'GV004', N'Phạm Thị Dung', 'ptd@university.edu.vn', '0901234570', 2, '1988-11-25', N'Nữ', N'Thạc sĩ', N'Giảng viên', '2012-09-01'),
(8, 'GV005', N'Hoàng Văn Em', 'hve@university.edu.vn', '0901234571', 3, '1983-07-30', N'Nam', N'Tiến sĩ', N'Phó Giáo sư', '2007-09-01');
GO

-- =============================================
-- 5. INSERT COURSE
-- =============================================
INSERT INTO Course (CourseCode, CourseName, Credits, DepartmentID, TheoryHours, PracticeHours, Description) VALUES
('IT001', N'Nhập môn Lập trình', 3, 1, 30, 30, N'Học lập trình cơ bản với C/C++'),
('IT002', N'Cấu trúc Dữ liệu và Giải thuật', 4, 1, 45, 30, N'Các cấu trúc dữ liệu và giải thuật cơ bản'),
('IT003', N'Lập trình Hướng đối tượng', 3, 1, 30, 30, N'Lập trình OOP với Java/C#'),
('IT004', N'Cơ sở Dữ liệu', 3, 1, 30, 30, N'Thiết kế và quản lý cơ sở dữ liệu'),
('IT005', N'Mạng Máy tính', 3, 1, 30, 30, N'Kiến thức về mạng máy tính'),
('SE001', N'Công nghệ Phần mềm', 3, 2, 30, 30, N'Quy trình phát triển phần mềm'),
('SE002', N'Phân tích Thiết kế Hệ thống', 3, 2, 30, 30, N'Phân tích và thiết kế hệ thống thông tin'),
('SE003', N'Kiểm thử Phần mềm', 3, 2, 30, 30, N'Các kỹ thuật kiểm thử phần mềm'),
('CS001', N'Trí tuệ Nhân tạo', 3, 3, 30, 30, N'Các thuật toán AI cơ bản'),
('CS002', N'Học Máy', 3, 3, 30, 30, N'Machine Learning cơ bản');
GO

-- Thêm môn tiên quyết
UPDATE Course SET PrerequisiteCourseID = 1 WHERE CourseCode = 'IT002'; -- CTDL cần Nhập môn
UPDATE Course SET PrerequisiteCourseID = 1 WHERE CourseCode = 'IT003'; -- OOP cần Nhập môn
UPDATE Course SET PrerequisiteCourseID = 3 WHERE CourseCode = 'IT004'; -- CSDL cần OOP
UPDATE Course SET PrerequisiteCourseID = 2 WHERE CourseCode = 'CS001'; -- AI cần CTDL
GO

-- =============================================
-- 6. INSERT SEMESTER
-- =============================================
INSERT INTO Semester (SemesterCode, SemesterName, StartDate, EndDate, IsActive) VALUES
('HK1-2024', N'Học kỳ 1 năm 2024-2025', '2024-09-01', '2025-01-15', 1),
('HK2-2024', N'Học kỳ 2 năm 2024-2025', '2025-02-01', '2025-06-30', 0),
('HK3-2024', N'Học kỳ hè năm 2024-2025', '2025-07-01', '2025-08-31', 0);
GO

-- =============================================
-- 7. INSERT CLASSROOM
-- =============================================
INSERT INTO Classroom (ClassroomCode, ClassroomName, Building, Floor, Capacity, RoomType, Equipment) VALUES
('A101', N'Phòng A101', N'Nhà A', 1, 60, N'Lý thuyết', N'Máy chiếu, Loa'),
('A102', N'Phòng A102', N'Nhà A', 1, 60, N'Lý thuyết', N'Máy chiếu, Loa'),
('A201', N'Phòng A201', N'Nhà A', 2, 80, N'Lý thuyết', N'Máy chiếu, Loa, Micro'),
('B101', N'Phòng B101', N'Nhà B', 1, 40, N'Máy tính', N'40 máy tính, Máy chiếu'),
('B102', N'Phòng B102', N'Nhà B', 1, 40, N'Máy tính', N'40 máy tính, Máy chiếu'),
('B201', N'Phòng B201', N'Nhà B', 2, 50, N'Máy tính', N'50 máy tính, Máy chiếu'),
('C101', N'Phòng C101', N'Nhà C', 1, 100, N'Hội trường', N'Máy chiếu, Hệ thống âm thanh'),
('D101', N'Phòng D101', N'Nhà D', 1, 30, N'Thực hành', N'Thiết bị thực hành mạng');
GO

-- =============================================
-- 8. INSERT COURSECLASS
-- =============================================
INSERT INTO CourseClass (ClassCode, CourseID, TeacherID, SemesterID, MaxStudents, CurrentStudents, Status) VALUES
('IT001.01', 1, 1, 1, 60, 45, N'Đang học'),
('IT001.02', 1, 2, 1, 60, 50, N'Đang học'),
('IT002.01', 2, 1, 1, 50, 40, N'Đang học'),
('IT003.01', 3, 2, 1, 60, 55, N'Đang học'),
('IT004.01', 4, 3, 1, 50, 35, N'Đang học'),
('IT005.01', 5, 4, 1, 60, 48, N'Đang học'),
('SE001.01', 6, 3, 1, 50, 42, N'Đang học'),
('SE002.01', 7, 4, 1, 50, 38, N'Đang học'),
('CS001.01', 9, 5, 1, 40, 30, N'Đang học'),
('CS002.01', 10, 5, 1, 40, 28, N'Đang học');
GO

-- =============================================
-- 9. INSERT SCHEDULE
-- =============================================
-- Lớp IT001.01: Thứ 2, 4 (7h-9h30)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(1, 1, 2, '07:00', '09:30', '2024-09-02', '2025-01-13'),
(1, 1, 4, '07:00', '09:30', '2024-09-04', '2025-01-15');

-- Lớp IT001.02: Thứ 3, 5 (9h30-12h)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(2, 2, 3, '09:30', '12:00', '2024-09-03', '2025-01-14'),
(2, 2, 5, '09:30', '12:00', '2024-09-05', '2025-01-16');

-- Lớp IT002.01: Thứ 2, 4 (13h-15h30)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(3, 3, 2, '13:00', '15:30', '2024-09-02', '2025-01-13'),
(3, 3, 4, '13:00', '15:30', '2024-09-04', '2025-01-15');

-- Lớp IT003.01: Thứ 3, 5 (13h-15h30)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(4, 4, 3, '13:00', '15:30', '2024-09-03', '2025-01-14'),
(4, 4, 5, '13:00', '15:30', '2024-09-05', '2025-01-16');

-- Lớp IT004.01: Thứ 2, 4 (15h30-18h)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(5, 5, 2, '15:30', '18:00', '2024-09-02', '2025-01-13'),
(5, 5, 4, '15:30', '18:00', '2024-09-04', '2025-01-15');

-- Lớp IT005.01: Thứ 3, 5 (15h30-18h)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(6, 6, 3, '15:30', '18:00', '2024-09-03', '2025-01-14'),
(6, 6, 5, '15:30', '18:00', '2024-09-05', '2025-01-16');

-- Lớp SE001.01: Thứ 6 (7h-12h)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(7, 1, 6, '07:00', '12:00', '2024-09-06', '2025-01-17');

-- Lớp SE002.01: Thứ 7 (7h-12h)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(8, 2, 7, '07:00', '12:00', '2024-09-07', '2025-01-18');

-- Lớp CS001.01: Thứ 6 (13h-18h)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(9, 4, 6, '13:00', '18:00', '2024-09-06', '2025-01-17');

-- Lớp CS002.01: Thứ 7 (13h-18h)
INSERT INTO Schedule (ClassID, ClassroomID, DayOfWeek, StartTime, EndTime, StartDate, EndDate) VALUES
(10, 5, 7, '13:00', '18:00', '2024-09-07', '2025-01-18');

GO

PRINT N'✅ Dữ liệu mẫu đã được insert thành công!';
PRINT N'';
PRINT N'📋 THÔNG TIN TÀI KHOẢN MẪU:';
PRINT N'Admin: username=admin, password=123456';
PRINT N'Phòng Đào Tạo: username=daotao01, password=123456';
PRINT N'Giảng viên: username=gv001, password=123456';
GO
