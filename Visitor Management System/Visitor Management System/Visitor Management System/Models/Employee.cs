namespace Visitor_Management_System.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? Department { get; set; }
        public ICollection<VisitLog> VisitLogs { get; set; }
    }
}
