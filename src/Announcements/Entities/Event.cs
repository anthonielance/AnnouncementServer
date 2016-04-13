using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USF.Announcements.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime? EventDate { get; set; }
        public string Location { get; set; }
    }
}
