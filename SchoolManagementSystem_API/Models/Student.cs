namespace SchoolManagementSystem_API.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int student_id { get; set; }
        public string? full_name { get; set; }
        public string? gender { get; set; }
        public DateTime dob { get; set; }
        public int phone_number { get; set; }
        public string? address { get; set; }
        public string? grade_id { get; set; }
        public string? section { get; set; }
        public string? admission_by { get; set; }
        public string? created_by { get; set; }
        public DateTime created_at { get; set; }
    }
}
