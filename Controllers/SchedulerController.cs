using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Scheduler.Models;

namespace Scheduler.Controllers
{
    [Produces("application/json")]
    [Route("api/Scheduler")]
    public class SchedulerController : Controller
    {
        private readonly SchedulerContext _context;

        public SchedulerController(SchedulerContext context)
        {
            _context = context;
        }

        [HttpPost(Name = "AddSchedule")]
        public IActionResult Add([FromBody] SchedulerItem item)
        {
            SchedulerItem sItem = new SchedulerItem();
            var foundItem = _context.SchedulerItems.FirstOrDefault(s => s.Id == item.Id);
            if (foundItem == null)
            {
                sItem.Subject = item.Subject;
                sItem.Location = item.Location;
                sItem.StartDateTime = item.StartDateTime;
                sItem.EndDateTime = item.EndDateTime;
                sItem.IsAllDayEvent = item.IsAllDayEvent;
                sItem.ContactInfo = item.ContactInfo;
                _context.SchedulerItems.Add(sItem);
                _context.SaveChanges();
            }
            return Ok(sItem);
        }

        [HttpGet]
        public IEnumerable<SchedulerItem> GetAll()
        {
            return _context.SchedulerItems.ToList();
        }
    }
}