using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USF.Announcements.Entities
{
    public class Announcement
    {
        public Announcement()
        {
            Id = 0;
            Attachments = new List<string>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public bool IsPriority { get; set; }
        public AnnouncementType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DetailsLink { get; set; }
        public List<string> Attachments { get; set; }

        // Event Details
        public int? EventId { get; set; }
        public Event Event { get; set; }

        // Person Details
        public int? PersonId{ get; set; }
        public Person Person { get; set; }
    }
}
