-- =============================================
-- Stored Procedures cho hệ thống
-- =============================================

USE CourseRegistrationDB;
GO

-- =============================================
-- SP: Kiểm tra trùng lịch phòng học
-- =============================================
CREATE OR ALTER PROCEDURE sp_CheckClassroomConflict
    @ClassroomID INT,
    @DayOfWeek INT,
    @StartTime TIME,
    @EndTime TIME,
    @StartDate DATE,
    @EndDate DATE,
    @ExcludeScheduleID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT COUNT(*) AS ConflictCount
    FROM Schedule
    WHERE ClassroomID = @ClassroomID
        AND DayOfWeek = @DayOfWeek
        AND (@ExcludeScheduleID IS NULL OR ScheduleID != @ExcludeScheduleID)
        AND (
            -- Kiểm tra overlap về thời gian
            (@StartTime < EndTime AND @EndTime > StartTime)
            AND
            -- Kiểm tra overlap về ngày
            (@StartDate <= EndDate AND @EndDate >= StartDate)
        );
END;
GO

-- =============================================
-- SP: Kiểm tra trùng lịch giảng viên
-- =============================================
CREATE OR ALTER PROCEDURE sp_CheckTeacherConflict
    @TeacherID INT,
    @DayOfWeek INT,
    @StartTime TIME,
    @EndTime TIME,
    @StartDate DATE,
    @EndDate DATE,
    @ExcludeClassID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT COUNT(*) AS ConflictCount
    FROM Schedule s
    INNER JOIN CourseClass cc ON s.ClassID = cc.ClassID
    WHERE cc.TeacherID = @TeacherID
        AND s.DayOfWeek = @DayOfWeek
        AND (@ExcludeClassID IS NULL OR s.ClassID != @ExcludeClassID)
        AND (
            -- Kiểm tra overlap về thời gian
            (@StartTime < s.EndTime AND @EndTime > s.StartTime)
            AND
            -- Kiểm tra overlap về ngày
            (@StartDate <= s.EndDate AND @EndDate >= s.StartDate)
        );
END;
GO

-- =============================================
-- SP: Lấy thời khóa biểu theo giảng viên
-- =============================================
CREATE OR ALTER PROCEDURE sp_GetTeacherSchedule
    @TeacherID INT,
    @SemesterID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        s.ScheduleID,
        cc.ClassCode,
        c.CourseName,
        cr.ClassroomCode,
        cr.ClassroomName,
        s.DayOfWeek,
        CASE s.DayOfWeek
            WHEN 2 THEN N'Thứ 2'
            WHEN 3 THEN N'Thứ 3'
            WHEN 4 THEN N'Thứ 4'
            WHEN 5 THEN N'Thứ 5'
            WHEN 6 THEN N'Thứ 6'
            WHEN 7 THEN N'Thứ 7'
            WHEN 8 THEN N'Chủ nhật'
        END AS DayOfWeekText,
        s.StartTime,
        s.EndTime,
        s.StartDate,
        s.EndDate,
        cc.CurrentStudents,
        cc.MaxStudents
    FROM Schedule s
    INNER JOIN CourseClass cc ON s.ClassID = cc.ClassID
    INNER JOIN Course c ON cc.CourseID = c.CourseID
    INNER JOIN Classroom cr ON s.ClassroomID = cr.ClassroomID
    WHERE cc.TeacherID = @TeacherID
        AND (@SemesterID IS NULL OR cc.SemesterID = @SemesterID)
    ORDER BY s.DayOfWeek, s.StartTime;
END;
GO

-- =============================================
-- SP: Lấy thời khóa biểu theo phòng học
-- =============================================
CREATE OR ALTER PROCEDURE sp_GetClassroomSchedule
    @ClassroomID INT,
    @SemesterID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        s.ScheduleID,
        cc.ClassCode,
        c.CourseName,
        t.FullName AS TeacherName,
        s.DayOfWeek,
        CASE s.DayOfWeek
            WHEN 2 THEN N'Thứ 2'
            WHEN 3 THEN N'Thứ 3'
            WHEN 4 THEN N'Thứ 4'
            WHEN 5 THEN N'Thứ 5'
            WHEN 6 THEN N'Thứ 6'
            WHEN 7 THEN N'Thứ 7'
            WHEN 8 THEN N'Chủ nhật'
        END AS DayOfWeekText,
        s.StartTime,
        s.EndTime,
        s.StartDate,
        s.EndDate,
        cc.CurrentStudents
    FROM Schedule s
    INNER JOIN CourseClass cc ON s.ClassID = cc.ClassID
    INNER JOIN Course c ON cc.CourseID = c.CourseID
    INNER JOIN Teacher t ON cc.TeacherID = t.TeacherID
    WHERE s.ClassroomID = @ClassroomID
        AND (@SemesterID IS NULL OR cc.SemesterID = @SemesterID)
    ORDER BY s.DayOfWeek, s.StartTime;
END;
GO

-- =============================================
-- SP: Lấy danh sách lớp học phần theo học kỳ
-- =============================================
CREATE OR ALTER PROCEDURE sp_GetCourseClassesBySemester
    @SemesterID INT
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        cc.ClassID,
        cc.ClassCode,
        c.CourseCode,
        c.CourseName,
        c.Credits,
        t.FullName AS TeacherName,
        d.DepartmentName,
        cc.MaxStudents,
        cc.CurrentStudents,
        cc.Status,
        sem.SemesterName
    FROM CourseClass cc
    INNER JOIN Course c ON cc.CourseID = c.CourseID
    LEFT JOIN Teacher t ON cc.TeacherID = t.TeacherID
    LEFT JOIN Department d ON c.DepartmentID = d.DepartmentID
    INNER JOIN Semester sem ON cc.SemesterID = sem.SemesterID
    WHERE cc.SemesterID = @SemesterID
    ORDER BY c.CourseCode, cc.ClassCode;
END;
GO

-- =============================================
-- SP: Báo cáo khối lượng giảng dạy theo giảng viên
-- =============================================
CREATE OR ALTER PROCEDURE sp_ReportTeachingLoad
    @SemesterID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        t.TeacherCode,
        t.FullName,
        d.DepartmentName,
        COUNT(DISTINCT cc.ClassID) AS TotalClasses,
        SUM(c.Credits) AS TotalCredits,
        SUM(cc.CurrentStudents) AS TotalStudents,
        SUM(c.TheoryHours + c.PracticeHours) AS TotalHours
    FROM Teacher t
    LEFT JOIN CourseClass cc ON t.TeacherID = cc.TeacherID
    LEFT JOIN Course c ON cc.CourseID = c.CourseID
    LEFT JOIN Department d ON t.DepartmentID = d.DepartmentID
    WHERE (@SemesterID IS NULL OR cc.SemesterID = @SemesterID)
        AND t.IsActive = 1
    GROUP BY t.TeacherCode, t.FullName, d.DepartmentName
    ORDER BY TotalCredits DESC;
END;
GO

-- =============================================
-- SP: Báo cáo tình hình sử dụng phòng học
-- =============================================
CREATE OR ALTER PROCEDURE sp_ReportClassroomUsage
    @SemesterID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        cr.ClassroomCode,
        cr.ClassroomName,
        cr.Building,
        cr.Capacity,
        cr.RoomType,
        COUNT(DISTINCT s.ScheduleID) AS TotalSchedules,
        COUNT(DISTINCT s.ClassID) AS TotalClasses,
        SUM(DATEDIFF(HOUR, s.StartTime, s.EndTime)) AS TotalHours
    FROM Classroom cr
    LEFT JOIN Schedule s ON cr.ClassroomID = s.ClassroomID
    LEFT JOIN CourseClass cc ON s.ClassID = cc.ClassID
    WHERE (@SemesterID IS NULL OR cc.SemesterID = @SemesterID)
        AND cr.IsActive = 1
    GROUP BY cr.ClassroomCode, cr.ClassroomName, cr.Building, cr.Capacity, cr.RoomType
    ORDER BY TotalHours DESC;
END;
GO

-- =============================================
-- SP: Thống kê theo khoa
-- =============================================
CREATE OR ALTER PROCEDURE sp_ReportByDepartment
    @SemesterID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        d.DepartmentCode,
        d.DepartmentName,
        COUNT(DISTINCT t.TeacherID) AS TotalTeachers,
        COUNT(DISTINCT c.CourseID) AS TotalCourses,
        COUNT(DISTINCT cc.ClassID) AS TotalClasses,
        SUM(cc.CurrentStudents) AS TotalStudents
    FROM Department d
    LEFT JOIN Teacher t ON d.DepartmentID = t.DepartmentID AND t.IsActive = 1
    LEFT JOIN Course c ON d.DepartmentID = c.DepartmentID AND c.IsActive = 1
    LEFT JOIN CourseClass cc ON c.CourseID = cc.CourseID
    WHERE (@SemesterID IS NULL OR cc.SemesterID = @SemesterID)
    GROUP BY d.DepartmentCode, d.DepartmentName
    ORDER BY d.DepartmentCode;
END;
GO

-- =============================================
-- SP: Tìm kiếm giảng viên
-- =============================================
CREATE OR ALTER PROCEDURE sp_SearchTeacher
    @Keyword NVARCHAR(100) = NULL,
    @DepartmentID INT = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        t.TeacherID,
        t.TeacherCode,
        t.FullName,
        t.Email,
        t.Phone,
        d.DepartmentName,
        t.Degree,
        t.Title,
        t.IsActive
    FROM Teacher t
    LEFT JOIN Department d ON t.DepartmentID = d.DepartmentID
    WHERE (@Keyword IS NULL OR 
           t.FullName LIKE N'%' + @Keyword + '%' OR
           t.TeacherCode LIKE N'%' + @Keyword + '%' OR
           t.Email LIKE N'%' + @Keyword + '%')
        AND (@DepartmentID IS NULL OR t.DepartmentID = @DepartmentID)
    ORDER BY t.TeacherCode;
END;
GO

PRINT N'✅ Stored Procedures đã được tạo thành công!';
GO
