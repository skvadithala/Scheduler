using System;

namespace Scheduler.Models
{
    public class SchedulerItem
    {
        public long Id { get; set; }
        public string Subject { get; set; }
        public Address Location { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool IsAllDayEvent { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}
