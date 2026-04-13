using System;

namespace CourseRegistration.DTO.Entities
{
    /// <summary>
    /// Entity AuditLog - Nhật ký hệ thống
    /// </summary>
    public class AuditLog
    {
        public int LogID { get; set; }
        public int? AccountID { get; set; }
        public string Action { get; set; }
        public string TableName { get; set; }
        public int? RecordID { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string IPAddress { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation property
        public Account Account { get; set; }
    }
}
