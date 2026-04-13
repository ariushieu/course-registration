using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity CourseClass - Lớp học phần
    /// </summary>
    public class CourseClass
    {
        public int ClassID { get; set; }
        public string ClassCode { get; set; }
        public int CourseID { get; set; }
        public int? TeacherID { get; set; }
        public int SemesterID { get; set; }
        public int MaxStudents { get; set; }
        public int CurrentStudents { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public Semester Semester { get; set; }
    }
}
