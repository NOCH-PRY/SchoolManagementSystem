using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;

class Program
{
    static string connectionString = "Server=DESKTOP-0O4DJ93;Database=SchoolManagementDB;Integrated Security=True; User ID=sa;Password=Noch@@789"; // Replace with your actual connection string

    static void Main()
    {
        Console.WriteLine("1. Admin");
        Console.WriteLine("2. Students");
        Console.WriteLine("3. Teacher");
        Console.WriteLine("4. Class");
        Console.WriteLine("5. Attendance");
        Console.WriteLine("6. Exit...");
        Console.WriteLine("===========================>>>");

        while (true)
        {
            Console.Write("Enter option: ");
            //Console.WriteLine();
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Admin();
                    break;
                case "2":
                    Students();
                    break;
                case "3":
                    Teachers();
                    break;
                case "4":
                    Class();
                    break;
                case "5":
                    Attendance();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    static void Admin()
    {
        Console.WriteLine("1. Create User");
        Console.WriteLine("2. Read Users");
        Console.WriteLine("3. Update User");
        Console.WriteLine("4. Delete User");
        Console.WriteLine("5. Exit...");
        Console.WriteLine("===========================>>>");

        while (true)
        {
            Console.Write("Enter option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateUser();
                    break;
                case "2":
                    ReadUser();
                    break;
                case "3":
                    UpdateUser();
                    break;
                case "4":
                    DeleteUser();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    static void Students()
    {
        Console.WriteLine("1. Create Student");
        Console.WriteLine("2. Read Student");
        Console.WriteLine("3. Update Student");
        Console.WriteLine("4. Delete Student");
        Console.WriteLine("5. Exit...");
        Console.WriteLine("===========================>>>");

        while (true)
        {
            Console.Write("Enter option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateStudent();
                    break;
                case "2":
                    ReadStudents();
                    break;
                case "3":
                    UpdateStudent();
                    break;
                case "4":
                    DeleteStudent();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    static void Teachers()
    {
        Console.WriteLine("1. Create Teacher");
        Console.WriteLine("2. Read Teachers");
        Console.WriteLine("3. Update Teacher");
        Console.WriteLine("4. Delete Teacher");
        Console.WriteLine("5. Exit...");
        Console.WriteLine("===========================>>>");

        while (true)
        {
            Console.Write("Enter option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateTeacher();
                    break;
                case "2":
                    ReadTeachers();
                    break;
                case "3":
                    UpdateTeacher();
                    break;
                case "4":
                    DeleteTeacher();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    static void Class()
    {
        Console.WriteLine("1. Create Class");
        Console.WriteLine("2. Read Class");
        Console.WriteLine("3. Update Class");
        Console.WriteLine("4. Delete Class");
        Console.WriteLine("5. Exit...");
        Console.WriteLine("===========================>>>");

        while (true)
        {
            Console.Write("Enter option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateClass();
                    break;
                case "2":
                    ReadClass();
                    break;
                case "3":
                    UpdateClass();
                    break;
                case "4":
                    DeleteClass();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
    static void Attendance()
    {
        Console.WriteLine("1. Create Attendance");
        Console.WriteLine("2. Read Attendance");
        Console.WriteLine("3. Update Attendance");
        Console.WriteLine("4. Delete Attendance");
        Console.WriteLine("5. Exit...");
        Console.WriteLine("===========================>>>");

        while (true)
        {
            Console.Write("Enter option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateAttendance();
                    break;
                case "2":
                    ReadAttendance();
                    break;
                case "3":
                    UpdateAttendance();
                    break;
                case "4":
                    DeleteAttendance();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }

    //==========>>Admin<<==============
    static void CreateUser()
    {
        Console.Write("Enter user name: ");
        string name = Console.ReadLine();

        Console.Write("Enter email address: ");
        string email = Console.ReadLine();

        Console.Write("Enter user password: ");
        string password = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO [Users] (Name, Email, Password) VALUES (@Name, @Email, @Password)";
            connection.Execute(insertQuery, new { Name = name, Email = email, Password = password });

            Console.WriteLine("User created successfully");
        }
    }
    static void ReadUser()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM [Users]";
            IEnumerable<User> users = connection.Query<User>(selectQuery);
            Console.WriteLine("=========================================================");
            Console.WriteLine("ID \t|Name \t|Email \t\t|Password");
            Console.WriteLine("=========================================================");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Id} \t{user.Name} \t{user.Email} \t{user.Password}");
                Console.WriteLine("----------------------------------------------------------");
            }
        }
    }
    static void UpdateUser()
    {
        Console.Write("Enter user Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter updated name: ");
        string name = Console.ReadLine();

        Console.Write("Enter updated email: ");
        string email = Console.ReadLine();

        Console.Write("Enter updated password: ");
        string password = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string updateQuery = "UPDATE [Users] SET Name = @Name, Email = @Email, Password = @Password WHERE Id = @Id";
            connection.Execute(updateQuery, new { Id = id, Name = name, Email = email, Password = password });

            Console.WriteLine("User updated successfully");
        }
    }
    static void DeleteUser()
    {
        Console.Write("Enter user Id: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = "DELETE FROM [Users] WHERE Id = @Id";
            connection.Execute(deleteQuery, new { Id = id });

            Console.WriteLine("User deleted successfully");
        }
    }

    //==========>>Student<<==============
    static void CreateStudent()
    {
        Console.Write("Enter Student_ID: ");
        string student_id = Console.ReadLine();

        Console.Write("Enter Full_Name: ");
        string full_name = Console.ReadLine();

        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter DOB: ");
        string dob = Console.ReadLine();

        Console.Write("Enter Phone_Number: ");
        string phone_number = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Console.Write("Enter Class: ");
        string grade_id = Console.ReadLine();

        Console.Write("Enter Section: ");
        string section = Console.ReadLine();

        Console.Write("Enter Admission_By: ");
        string admission_by = Console.ReadLine();

        Console.Write("Enter Created_By: ");
        string created_by = Console.ReadLine();

        Console.Write("Enter Created_At: ");
        string created_at = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO [Students] (student_id, full_name, gender, dob, phone_number, address, grade_id, section, admission_by, created_by, created_at) VALUES (@Student_ID, @Full_Name, @Gender, @DOB, @Phone_Number, @Address, @Class, @Section, @Admission_By, @Created_By, @Created_At)";
            connection.Execute(insertQuery, new { 
                Student_ID = student_id, 
                Full_Name = full_name,
                Gender = gender,
                DOB = dob,
                Phone_Number = phone_number,
                Address = address,
                Class = grade_id,
                Section = section,
                Admission_By = admission_by,
                Created_By = created_by,
                Created_At = created_at,
            });

            Console.WriteLine("Student created successfully");
        }
    }
    static void ReadStudents()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM [Students]";
            IEnumerable<Student> students = connection.Query<Student>(selectQuery);
            Console.WriteLine("=================================================================================================================================================================");
            Console.WriteLine("ID \t|StudentID \t|Full Name \t|Gender \t|DOB \t|Address \t|GradeID \t|Section \t|AdmissionBy \t|CreateBy \t|CreateAt");
            Console.WriteLine("=================================================================================================================================================================");
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id} \t{student.student_id} \t{student.full_name} \t{student.gender} \t{student.dob} \t{student.phone_number} \t{student.address} \t{student.grade_id} \t{student.section} \t{student.admission_by} \t{student.created_by} \t{student.created_at}");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
    static void UpdateStudent()
    {
        Console.Write("Enter Student Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter updated student_id: ");
        string studentid = Console.ReadLine();

        Console.Write("Enter updated full_name: ");
        string fullname = Console.ReadLine();

        Console.Write("Enter updated gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter updated dob: ");
        string dob = Console.ReadLine();

        Console.Write("Enter updated phone_number: ");
        string phonenumber = Console.ReadLine();

        Console.Write("Enter updated address: ");
        string address = Console.ReadLine();

        Console.Write("Enter updated grade_id: ");
        string gradeid = Console.ReadLine();

        Console.Write("Enter updated section: ");
        string section = Console.ReadLine();

        Console.Write("Enter updated admission_by: ");
        string admissionby = Console.ReadLine();

        Console.Write("Enter updated created_by: ");
        string createdby = Console.ReadLine();

        Console.Write("Enter updated created_at: ");
        string createdat = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string updateQuery = "UPDATE [Students] SET student_id = @student_id, full_name = @full_name, gender = @gender, dob = @dob, phone_number = @phone_number, address = @address, grade_id = @grade_id, section = @section, admission_by = @admission_by, created_by = @created_by, created_at = @created_at  WHERE Id = @Id";
            connection.Execute(updateQuery, new { Id = id, student_id = studentid, full_name = fullname, gender = gender, dob = dob, phone_number = phonenumber, address = address, grade_id = gradeid, section = section, admission_by = admissionby, created_by = createdby, created_at = createdat });

            Console.WriteLine("Student updated successfully");
        }
    }
    static void DeleteStudent()
    {
        Console.Write("Enter Student Id: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = "DELETE FROM [Students] WHERE Id = @Id";
            connection.Execute(deleteQuery, new { Id = id });

            Console.WriteLine("Student deleted successfully");
        }
    }



    //==========>>Teachers<<==============
    static void CreateTeacher()
    {
        Console.Write("Enter TeacherID: ");
        string teacher_id = Console.ReadLine();

        Console.Write("Enter DOB: ");
        string dob = Console.ReadLine();

        Console.Write("Enter Gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter Address: ");
        string address = Console.ReadLine();

        Console.Write("Enter GradeID: ");
        string grade_id = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        string phone_number = Console.ReadLine();

        Console.Write("Enter CreatedBy: ");
        string created_by = Console.ReadLine();

        Console.Write("Enter CreatedAt: ");
        string created_at = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO [Teachers] (teacher_id, dob, gender, address, grade_id, phone_number, created_by, created_at) VALUES (@teacher_id, @dob, @gender, @address, @grade_id, @phone_number, @created_by, @created_at)";
            connection.Execute(insertQuery, new
            {
                teacher_id = teacher_id,
                dob = dob,
                gender = gender,
                address = address,
                grade_id = grade_id,
                phone_number = phone_number,
                created_by = created_by,
                created_at = created_at,
            });

            Console.WriteLine("Teacher created successfully");
        }
    }
    static void ReadTeachers()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM [Teachers]";
            IEnumerable<Teacher> teachers = connection.Query<Teacher>(selectQuery);
            Console.WriteLine("=================================================================================================================================================================");
            Console.WriteLine("ID \t|TeacherID \t|DOB \t|Gender \t|DOB \t|Address \t|GradeID \t|Phone \t|CreateBy \t|CreateAt");
            Console.WriteLine("=================================================================================================================================================================");
            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine($"{teacher.Id} \t{teacher.teacher_id} \t\t{teacher.dob} \t{teacher.gender} \t{teacher.address} \t{teacher.grade_id} \t\t{teacher.phone_number} \t{teacher.created_by} \t{teacher.created_at}");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
    static void UpdateTeacher()
    {
        Console.Write("Enter Teacher Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter updated TeacherID: ");
        string teacherid = Console.ReadLine();

        Console.Write("Enter updated Gender: ");
        string gender = Console.ReadLine();

        Console.Write("Enter updated DOB: ");
        string dob = Console.ReadLine();

        Console.Write("Enter updated PhoneNumber: ");
        string phonenumber = Console.ReadLine();

        Console.Write("Enter updated Address: ");
        string address = Console.ReadLine();

        Console.Write("Enter updated GradeID: ");
        string gradeid = Console.ReadLine();

        Console.Write("Enter updated CreatedBy: ");
        string createdby = Console.ReadLine();

        Console.Write("Enter updated CreatedAt: ");
        string createdat = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString)) 
        {
            connection.Open();

            string updateQuery = "UPDATE [Teachers] SET teacher_id = @teacher_id, dob = @dob, gender = @gender, address = @address, grade_id = @grade_id, phone_number = @phone_number, created_by = @created_by, created_at = @created_at  WHERE Id = @Id";
            connection.Execute(updateQuery, new { Id = id, teacher_id = teacherid, dob = dob, gender = gender,  address = address, grade_id = gradeid, phone_number = phonenumber, created_by = createdby, created_at = createdat });

            Console.WriteLine("Teacher updated successfully");
        }
    }
    static void DeleteTeacher()
    {
        Console.Write("Enter Teacher Id: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = "DELETE FROM [Teachers] WHERE Id = @Id";
            connection.Execute(deleteQuery, new { Id = id });

            Console.WriteLine("Teacher deleted successfully");
        }
    }

    //==========>>Classing<<==============
    static void CreateClass()
    {
        Console.Write("Enter ClassID: ");
        string gradeid = Console.ReadLine();

        Console.Write("Enter ClassName: ");
        string gradename = Console.ReadLine();

        Console.Write("Enter TeacherID: ");
        string teacherid = Console.ReadLine();

        Console.Write("Enter CreatedBy: ");
        string createdby = Console.ReadLine();

        Console.Write("Enter CreatedAt: ");
        string createdat = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO [Grades] (grade_id, grade_name, teacher_id, created_by, created_at) VALUES (@gradeid, @gradename, @teacherid, @createdby, @createdat)";
            connection.Execute(insertQuery, new
            {
                gradeid = gradeid,
                gradename = gradename,
                teacherid = teacherid,
                createdby = createdby,
                createdat = createdat,
            });

            Console.WriteLine("Class created successfully");
        }
    }
    static void ReadClass()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM [Grades]";
            IEnumerable<Grade> grades = connection.Query<Grade>(selectQuery);
            Console.WriteLine("===================================================================================================================");
            Console.WriteLine("ID \t|GradeID \t|Grade Name \t|TeacherID\t|CreateBy \t|CreateAt");
            Console.WriteLine("===================================================================================================================");
            foreach (Grade grade in grades)
            {
                Console.WriteLine($"{grade.Id} \t{grade.grade_id} \t\t{grade.grade_name} \t{grade.teacher_id}  \t{grade.created_by} \t{grade.created_at}");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            }
        }
    }
    static void UpdateClass()
    {
        Console.Write("Enter Class Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter updated Grade Name: ");
        string gradename = Console.ReadLine();

        Console.Write("Enter updated TeacherID: ");
        string teacherid = Console.ReadLine();

        Console.Write("Enter updated GradeID: ");
        string gradeid = Console.ReadLine();

        Console.Write("Enter updated CreatedBy: ");
        string createdby = Console.ReadLine();

        Console.Write("Enter updated CreatedAt: ");
        string createdat = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string updateQuery = "UPDATE [Grades] SET teacher_id = @teacher_id, grade_id = @grade_id, grade_name = @grade_name, created_by = @created_by, created_at = @created_at  WHERE Id = @Id";
            connection.Execute(updateQuery, new { Id = id, teacher_id = teacherid, grade_id = gradeid, grade_name = gradename, created_by = createdby, created_at = createdat });

            Console.WriteLine("Class updated successfully");
        }
    }
    static void DeleteClass()
    {
        Console.Write("Enter user Id: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = "DELETE FROM [Grades] WHERE Id = @Id";
            connection.Execute(deleteQuery, new { Id = id });

            Console.WriteLine("User deleted successfully");
        }
    }

    //==========>>Attendance<<==============
    static void CreateAttendance()
    {
        Console.Write("Enter AttendanceID: ");
        string attendanceid = Console.ReadLine();

        Console.Write("Enter StudentID: ");
        string studentid = Console.ReadLine();

        Console.Write("Enter DateTime: ");
        string datetime = Console.ReadLine();

        Console.Write("Enter CreatedBy: ");
        string createdby = Console.ReadLine();

        Console.Write("Enter CreatedAt: ");
        string createdat = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO [Attendances] (attendance_id, student_id, date_time_recorded, created_by, created_at) VALUES (@attendanceid, @studentid, @datetime, @createdby, @createdat)";
            connection.Execute(insertQuery, new
            {
                attendanceid = attendanceid,
                studentid = studentid,
                datetime = datetime,
                createdby = createdby,
                createdat = createdat,
            }); ;

            Console.WriteLine("Attendance created successfully");
        }
    }
    static void ReadAttendance()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM [Attendances]";
            IEnumerable<Attendance> attendances = connection.Query<Attendance>(selectQuery);
            Console.WriteLine("=======================================================================================================================");
            Console.WriteLine("ID \t|AttendanceID \t|StudentID \t|DateTime \t|CreatedBy \t|CreateAt");
            Console.WriteLine("=======================================================================================================================");
            foreach (Attendance attendance in attendances)
            {
                Console.WriteLine($"{attendance.Id} \t{attendance.attendance_id} \t\t{attendance.student_id} \t\t{attendance.date_time_recorded}  \t{attendance.created_by} \t{attendance.created_at}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
    static void UpdateAttendance()
    {
        Console.Write("Enter Attendance Id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter updat AttendanceID: ");
        string attendanceid = Console.ReadLine();

        Console.Write("Enter updated StudentID: ");
        string studentid = Console.ReadLine();

        Console.Write("Enter updated DateTime: ");
        string datetime = Console.ReadLine();

        Console.Write("Enter updated CreatedBy: ");
        string createdby = Console.ReadLine();

        Console.Write("Enter updated CreatedAt: ");
        string createdat = Console.ReadLine();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string updateQuery = "UPDATE [Attendances] SET attendance_id = @attendance_id, stundent_id = @stundent_id, date_time_recorded = @date_time_recorded, created_by = @created_by, created_at = @created_at  WHERE Id = @Id";
            connection.Execute(updateQuery, new { Id = id, attendance_id = attendanceid, stundent_id = studentid, date_time_recorded = datetime, created_by = createdby, created_at = createdat });

            Console.WriteLine("Attendance updated successfully");
        }
    }
    static void DeleteAttendance()
    {
        Console.Write("Enter Attendance Id: ");
        int id = int.Parse(Console.ReadLine());

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = "DELETE FROM [Attendances] WHERE Id = @Id";
            connection.Execute(deleteQuery, new { Id = id });

            Console.WriteLine("Attendance deleted successfully");
        }
    }

}

class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public object Password { get; internal set; }
}
class Student
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
class Teacher
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
class Grade
{
    public int Id { get; set; }
    public int grade_id { get; set; }
    public string? grade_name { get; set; }
    public string? teacher_id { get; set; }
    public string? created_by { get; set; }
    public DateTime created_at { get; set; }
}
class Attendance{
    public int Id { get; set; }
    public int attendance_id { get; set; }
    public int student_id { get; set; }
    public DateTime date_time_recorded { get; set; }
    public string? status { get; set; }
    public string? created_by { get; set; }
    public DateTime created_at { get; set; }
}