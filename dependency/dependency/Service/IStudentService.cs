using dependency.Model;

namespace dependency.Service
{
    public interface IStudentService
    {
        List<Students> Get();
        public string Add(Students AddStudent);
        public string Update(Students NewStudent);
        public string Delete(int id);

        public string Login(string name, string password);
    }
}
