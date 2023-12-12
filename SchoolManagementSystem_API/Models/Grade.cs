namespace SchoolManagementSystem_API.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int grade_id { get; set; }
        public string? grade_name { get; set; }
        public string? teacher_id { get; set; }
        public string? created_by { get; set; }
        public DateTime created_at { get; set; }
    }
}
