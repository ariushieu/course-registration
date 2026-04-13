using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity Semester - Học kỳ
    /// </summary>
    public class Semester
    {
        public int SemesterID { get; set; }
        public string SemesterCode { get; set; }
        public string SemesterName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
