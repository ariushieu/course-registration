using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity Classroom - Phòng học
    /// </summary>
    public class Classroom
    {
        public int ClassroomID { get; set; }
        public string ClassroomCode { get; set; }
        public string ClassroomName { get; set; }
        public string Building { get; set; }
        public int? Floor { get; set; }
        public int Capacity { get; set; }
        public string RoomType { get; set; }
        public string Equipment { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
