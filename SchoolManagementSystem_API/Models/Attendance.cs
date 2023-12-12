namespace SchoolManagementSystem_API.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int attendance_id { get; set; }
        public int student_id { get; set; }
        public DateTime date_time_recorded { get; set; }
        public string? status { get; set; }
        public string? created_by { get; set; }
        public DateTime created_at { get; set; }
    }
}
