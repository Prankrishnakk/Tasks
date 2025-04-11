using dependency.Model;
using System.Collections.Generic;
using System.Linq;

namespace dependency.Service    
{
    public class StudentService : IStudentService
    {
        public static List<Students> students = new List<Students>
       {
           new Students { Id = 1, Name = "mob", Mark = 50,Password ="dehdejdje"},
           new Students { Id = 2, Name = "hob", Mark= 20,Password ="dehdeje" },
           new Students { Id = 3, Name = "kob", Mark = 30,Password ="dejdje" },
           new Students { Id = 5, Name = "pob", Mark= 80,Password ="ddejdje" },
       };

        public List<Students> Get()
        {
            return students;
        }

        public string Add(Students AddStudent)
        {
            if (AddStudent == null)
            {
                return "Student data is null. Not added.";
            }
            students.Add(AddStudent);
            return "Student added successfully.";
        }

        public string Update(Students NewStudent)
        {
            var existingStudents = students.FirstOrDefault(i => i.Id == NewStudent.Id);
            if (existingStudents == null)
            {
                return "Student not found.";
            }
            existingStudents.Name = NewStudent.Name;
            existingStudents.Mark = NewStudent.Mark;
            return "Updation done successfully.";
        }

        public string Delete(int id)
        {
            var res = students.FirstOrDefault(i => i.Id == id);
            if (res == null)
            {
                return "Student not found.";
            }
            students.Remove(res);
            return "Student removed successfully.";
        }
        public string Login(string username, string password) 
        {
            return students.Any(i => i.Name == username && i.Password == password) ? "Login Successful" : "Login Failed";

        }


    }
}

