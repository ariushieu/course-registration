# ENTITY RELATIONSHIP DIAGRAM (ERD)

## Sơ đồ quan hệ các bảng

```
┌─────────────────┐
│    Account      │
│─────────────────│
│ AccountID (PK)  │
│ Username        │
│ Password        │
│ RoleID (FK)     │
│ IsActive        │
│ CreatedDate     │
└────────┬────────┘
         │
         │ 1:1
         │
┌────────┴────────┐         ┌─────────────────┐
│   Teacher       │         │      Role       │
│─────────────────│         │─────────────────│
│ TeacherID (PK)  │         │ RoleID (PK)     │
│ AccountID (FK)  │◄────────│ RoleName        │
│ FullName        │    N:1  │ Description     │
│ Email           │         └─────────────────┘
│ Phone           │
│ DepartmentID(FK)│
│ Address         │
│ DateOfBirth     │
└────────┬────────┘
         │
         │ N:1
         │
┌────────┴────────┐
│   Department    │
│─────────────────│
│ DepartmentID(PK)│
│ DepartmentCode  │
│ DepartmentName  │
│ Description     │
│ FoundedDate     │
└────────┬────────┘
         │
         │ 1:N
         │
┌────────┴────────┐
│     Course      │
│─────────────────│
│ CourseID (PK)   │
│ CourseCode      │
│ CourseName      │
│ Credits         │
│ DepartmentID(FK)│
│ Description     │
│ PrerequisiteID  │◄─┐ (Self-reference)
└────────┬────────┘  │
         │           │
         │ 1:N       │
         │           │
┌────────┴────────┐  │
│  CourseClass    │  │
│─────────────────│  │
│ ClassID (PK)    │  │
│ ClassCode       │  │
│ CourseID (FK)   │──┘
│ TeacherID (FK)  │──┐
│ SemesterID (FK) │  │
│ MaxStudents     │  │
│ CurrentStudents │  │
│ Status          │  │
└────────┬────────┘  │
         │           │
         │ 1:N       │
         │           │
┌────────┴────────┐  │
│    Schedule     │  │
│─────────────────│  │
│ ScheduleID (PK) │  │
│ ClassID (FK)    │──┘
│ ClassroomID (FK)│──┐
│ DayOfWeek       │  │
│ StartTime       │  │
│ EndTime         │  │
│ StartDate       │  │
│ EndDate         │  │
└─────────────────┘  │
                     │
┌────────────────┐   │
│   Classroom    │   │
│────────────────│   │
│ ClassroomID(PK)│◄──┘
│ ClassroomCode  │
│ ClassroomName  │
│ Building       │
│ Floor          │
│ Capacity       │
│ RoomType       │
│ Equipment      │
└────────────────┘

┌─────────────────┐
│    Semester     │
│─────────────────│
│ SemesterID (PK) │
│ SemesterName    │
│ StartDate       │
│ EndDate         │
│ IsActive        │
└─────────────────┘
```

## Mô tả quan hệ:

1. **Account - Role**: N:1 (Nhiều tài khoản thuộc 1 vai trò)
2. **Account - Teacher**: 1:1 (1 tài khoản cho 1 giảng viên)
3. **Teacher - Department**: N:1 (Nhiều giảng viên thuộc 1 khoa)
4. **Department - Course**: 1:N (1 khoa có nhiều học phần)
5. **Course - Course**: 1:N (Học phần tiên quyết - Self-reference)
6. **Course - CourseClass**: 1:N (1 học phần có nhiều lớp học phần)
7. **Teacher - CourseClass**: 1:N (1 giảng viên dạy nhiều lớp)
8. **Semester - CourseClass**: 1:N (1 học kỳ có nhiều lớp)
9. **CourseClass - Schedule**: 1:N (1 lớp có nhiều buổi học)
10. **Classroom - Schedule**: 1:N (1 phòng có nhiều lịch học)

## Ràng buộc nghiệp vụ:

### Ràng buộc dữ liệu:

- Username phải unique
- Email phải unique và đúng format
- Phone phải đúng format
- Credits > 0
- MaxStudents > 0
- CurrentStudents <= MaxStudents
- StartTime < EndTime
- StartDate < EndDate
- Capacity > 0

### Ràng buộc logic:

- Không được xếp 2 lớp cùng 1 phòng trong cùng 1 khung giờ
- Không được xếp 1 giảng viên dạy 2 lớp trong cùng 1 khung giờ
- Số sinh viên hiện tại không được vượt quá số sinh viên tối đa
- Sức chứa phòng học phải >= số sinh viên tối đa của lớp
