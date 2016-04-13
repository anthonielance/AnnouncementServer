using System;
using System.Collections.Generic;
using USF.Announcements.Entities;

namespace USF.Announcements.ViewModels
{
    public class AnnouncementViewModel
    {
        public AnnouncementViewModel() { Attachments = new List<string>(); }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }

        public bool IsPriority { get; set; }

        public AnnouncementType Type { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DetailsLink { get; set; }

        public List<string> Attachments { get;   set;
        }

        // Event Details
        public bool IsEvent { get; set; }

        public DateTime? EventDate { get; set; }

        public string Location { get; set; }

        // Submitter Details
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}