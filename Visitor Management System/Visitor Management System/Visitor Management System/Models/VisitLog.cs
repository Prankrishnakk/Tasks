namespace Visitor_Management_System.Models
{
    public class VisitLog
    {
        public int Id { get; set; }
        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
        public int HostEmployeeId { get; set; }
        public Employee HostEmployee { get; set; }
        public DateTime VisitDate { get; set; }
        public TimeSpan ScheduledTime { get; set; }
        public TimeSpan? CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }
        public string? Purpose { get; set; }
        public string? Status { get; set; }
        public string? Notes { get; set; }
    }

}
