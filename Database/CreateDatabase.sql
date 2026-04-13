-- =============================================
-- HỆ THỐNG QUẢN LÝ ĐÀO TẠO TRƯỜNG ĐẠI HỌC
-- Script tạo Database và Tables
-- =============================================

USE master;
GO

-- Xóa database nếu đã tồn tại (cẩn thận khi chạy!)
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'CourseRegistrationDB')
BEGIN
    ALTER DATABASE CourseRegistrationDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE CourseRegistrationDB;
END
GO

-- Tạo database mới
CREATE DATABASE CourseRegistrationDB;
GO

USE CourseRegistrationDB;
GO

-- =============================================
-- 1. BẢNG ROLE (VAI TRÒ)
-- =============================================
CREATE TABLE Role (
    RoleID INT PRIMARY KEY IDENTITY(1,1),
    RoleName NVARCHAR(50) NOT NULL UNIQUE,
    Description NVARCHAR(255),
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- =============================================
-- 2. BẢNG ACCOUNT (TÀI KHOẢN)
-- =============================================
CREATE TABLE Account (
    AccountID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL, -- Nên mã hóa (hash)
    RoleID INT NOT NULL,
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),
    LastLogin DATETIME,
    CONSTRAINT FK_Account_Role FOREIGN KEY (RoleID) REFERENCES Role(RoleID)
);
GO

-- =============================================
-- 3. BẢNG DEPARTMENT (KHOA)
-- =============================================
CREATE TABLE Department (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentCode NVARCHAR(20) NOT NULL UNIQUE,
    DepartmentName NVARCHAR(255) NOT NULL,
    Description NVARCHAR(500),
    FoundedDate DATE,
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100),
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- =============================================
-- 4. BẢNG TEACHER (GIẢNG VIÊN)
-- =============================================
CREATE TABLE Teacher (
    TeacherID INT PRIMARY KEY IDENTITY(1,1),
    AccountID INT NOT NULL UNIQUE,
    TeacherCode NVARCHAR(20) NOT NULL UNIQUE,
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE,
    Phone NVARCHAR(20),
    DepartmentID INT,
    Address NVARCHAR(255),
    DateOfBirth DATE,
    Gender NVARCHAR(10),
    Degree NVARCHAR(50), -- Học vị: Thạc sĩ, Tiến sĩ, ...
    Title NVARCHAR(50), -- Chức danh: Giảng viên, Phó giáo sư, ...
    HireDate DATE,
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Teacher_Account FOREIGN KEY (AccountID) REFERENCES Account(AccountID),
    CONSTRAINT FK_Teacher_Department FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);
GO

-- =============================================
-- 5. BẢNG COURSE (HỌC PHẦN/MÔN HỌC)
-- =============================================
CREATE TABLE Course (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseCode NVARCHAR(20) NOT NULL UNIQUE,
    CourseName NVARCHAR(255) NOT NULL,
    Credits INT NOT NULL CHECK (Credits > 0),
    DepartmentID INT,
    TheoryHours INT DEFAULT 0, -- Số tiết lý thuyết
    PracticeHours INT DEFAULT 0, -- Số tiết thực hành
    PrerequisiteCourseID INT, -- Môn tiên quyết
    Description NVARCHAR(500),
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Course_Department FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID),
    CONSTRAINT FK_Course_Prerequisite FOREIGN KEY (PrerequisiteCourseID) REFERENCES Course(CourseID)
);
GO

-- =============================================
-- 6. BẢNG SEMESTER (HỌC KỲ)
-- =============================================
CREATE TABLE Semester (
    SemesterID INT PRIMARY KEY IDENTITY(1,1),
    SemesterCode NVARCHAR(20) NOT NULL UNIQUE,
    SemesterName NVARCHAR(100) NOT NULL, -- VD: Học kỳ 1 năm 2024-2025
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL,
    IsActive BIT DEFAULT 0, -- Chỉ 1 học kỳ active tại 1 thời điểm
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT CHK_Semester_Date CHECK (EndDate > StartDate)
);
GO

-- =============================================
-- 7. BẢNG CLASSROOM (PHÒNG HỌC)
-- =============================================
CREATE TABLE Classroom (
    ClassroomID INT PRIMARY KEY IDENTITY(1,1),
    ClassroomCode NVARCHAR(20) NOT NULL UNIQUE,
    ClassroomName NVARCHAR(100) NOT NULL,
    Building NVARCHAR(50), -- Tòa nhà
    Floor INT, -- Tầng
    Capacity INT NOT NULL CHECK (Capacity > 0), -- Sức chứa
    RoomType NVARCHAR(50), -- Loại phòng: Lý thuyết, Thực hành, Máy tính, ...
    Equipment NVARCHAR(500), -- Thiết bị: Máy chiếu, Máy tính, ...
    IsActive BIT DEFAULT 1,
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- =============================================
-- 8. BẢNG COURSECLASS (LỚP HỌC PHẦN)
-- =============================================
CREATE TABLE CourseClass (
    ClassID INT PRIMARY KEY IDENTITY(1,1),
    ClassCode NVARCHAR(20) NOT NULL UNIQUE,
    CourseID INT NOT NULL,
    TeacherID INT,
    SemesterID INT NOT NULL,
    MaxStudents INT NOT NULL CHECK (MaxStudents > 0),
    CurrentStudents INT DEFAULT 0 CHECK (CurrentStudents >= 0),
    Status NVARCHAR(20) DEFAULT N'Mở đăng ký', -- Mở đăng ký, Đang học, Kết thúc
    Note NVARCHAR(500),
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_CourseClass_Course FOREIGN KEY (CourseID) REFERENCES Course(CourseID),
    CONSTRAINT FK_CourseClass_Teacher FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    CONSTRAINT FK_CourseClass_Semester FOREIGN KEY (SemesterID) REFERENCES Semester(SemesterID),
    CONSTRAINT CHK_CourseClass_Students CHECK (CurrentStudents <= MaxStudents)
);
GO

-- =============================================
-- 9. BẢNG SCHEDULE (THỜI KHÓA BIỂU)
-- =============================================
CREATE TABLE Schedule (
    ScheduleID INT PRIMARY KEY IDENTITY(1,1),
    ClassID INT NOT NULL,
    ClassroomID INT NOT NULL,
    DayOfWeek INT NOT NULL CHECK (DayOfWeek BETWEEN 2 AND 8), -- 2=Thứ 2, 8=Chủ nhật
    StartTime TIME NOT NULL,
    EndTime TIME NOT NULL,
    StartDate DATE NOT NULL, -- Ngày bắt đầu học
    EndDate DATE NOT NULL, -- Ngày kết thúc học
    Note NVARCHAR(255),
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Schedule_CourseClass FOREIGN KEY (ClassID) REFERENCES CourseClass(ClassID),
    CONSTRAINT FK_Schedule_Classroom FOREIGN KEY (ClassroomID) REFERENCES Classroom(ClassroomID),
    CONSTRAINT CHK_Schedule_Time CHECK (EndTime > StartTime),
    CONSTRAINT CHK_Schedule_Date CHECK (EndDate > StartDate)
);
GO

-- =============================================
-- 10. BẢNG AUDITLOG (NHẬT KÝ HỆ THỐNG)
-- =============================================
CREATE TABLE AuditLog (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    AccountID INT,
    Action NVARCHAR(100) NOT NULL, -- Login, Logout, Create, Update, Delete
    TableName NVARCHAR(50),
    RecordID INT,
    OldValue NVARCHAR(MAX),
    NewValue NVARCHAR(MAX),
    IPAddress NVARCHAR(50),
    CreatedDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_AuditLog_Account FOREIGN KEY (AccountID) REFERENCES Account(AccountID)
);
GO

-- =============================================
-- TẠO INDEX ĐỂ TỐI ƯU HIỆU SUẤT
-- =============================================

-- Index cho tìm kiếm
CREATE INDEX IX_Teacher_FullName ON Teacher(FullName);
CREATE INDEX IX_Teacher_Email ON Teacher(Email);
CREATE INDEX IX_Course_CourseName ON Course(CourseName);
CREATE INDEX IX_CourseClass_SemesterID ON CourseClass(SemesterID);
CREATE INDEX IX_Schedule_ClassID ON Schedule(ClassID);
CREATE INDEX IX_Schedule_DayOfWeek ON Schedule(DayOfWeek);

-- Index cho foreign key
CREATE INDEX IX_Account_RoleID ON Account(RoleID);
CREATE INDEX IX_Teacher_DepartmentID ON Teacher(DepartmentID);
CREATE INDEX IX_Course_DepartmentID ON Course(DepartmentID);
CREATE INDEX IX_CourseClass_TeacherID ON CourseClass(TeacherID);

GO

PRINT N'✅ Database và Tables đã được tạo thành công!';
GO
