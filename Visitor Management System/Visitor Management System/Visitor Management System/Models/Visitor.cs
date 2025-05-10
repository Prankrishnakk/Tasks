namespace Visitor_Management_System.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public ICollection<VisitLog> VisitLogs { get; set; }
    }

}
