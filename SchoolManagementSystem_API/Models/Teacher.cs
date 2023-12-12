namespace SchoolManagementSystem_API.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public int teacher_id { get; set; }
        public string? teacher_name { get; set; }
        public DateTime dob { get; set; }
        public string? gender { get; set; }
        public string? address { get; set; }
        public string? grade_id { get; set; }
        public int phone_number { get; set; }
        public string? created_by { get; set; }
        public DateTime created_at { get; set; }
    }
}
