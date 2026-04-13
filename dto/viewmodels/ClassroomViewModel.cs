namespace CourseRegistration.DTO.ViewModels
{
    /// <summary>
    /// ViewModel cho hiển thị Phòng học
    /// </summary>
    public class ClassroomViewModel
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
        
        // Helper properties
        public string Location => Floor.HasValue ? $"{Building} - Tầng {Floor}" : Building;
        public string Status => IsActive ? "Đang sử dụng" : "Không sử dụng";
    }
}
