using System;
using System.Collections.Generic;

namespace USF.Announcements.Entities
{
    public class InMemoryAnnouncementData : IAnnouncementData
    {
        List<Announcement> _announcements;

        public InMemoryAnnouncementData()
        {
            _announcements = new List<Announcement>
            {
                new Announcement {
                    Id = 1,
                    Title = "First Announcement",
                    Message = "The first announcement",
                    IsPriority = false,
                    Type = AnnouncementType.Staff,
                    StartDate = DateTime.Parse("April 18, 2016"),
                    EndDate = DateTime.Parse("April 20, 2016"),
                    DetailsLink = "https://google.com",
                    Attachments = { "https://sf.edu" },

                    // Event Details
                    EventId = 1,
                    Event = new Event
                    {
                        Id = 1,
                        Location = "Somewhere",
                        EventDate = DateTime.Parse("April 19, 2016 09:45:00AM"),
                    },

                    // Person Details
                    PersonId = 1,
                    Person = new Person
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Zoidberg",
                        Email = "JZoidberg@planex.com",
                        Phone = "555.555.5555",
                    }
                },
                new Announcement {
                    Id = 2,
                    Title = "Second Announcement",
                    Message = "The second announcement",
                    IsPriority = false,
                    Type = AnnouncementType.Staff,
                    StartDate = DateTime.Parse("April 10, 2016"),
                    EndDate = DateTime.Parse("April 12, 2016"),
                    DetailsLink = "https://google.com",
                    Attachments = { "https://sf.edu" },

                    // Event Details
                    EventId = 2,
                    Event = new Event
                    {
                        Id = 2,
                        Location = "Somewhere else",
                        EventDate = DateTime.Parse("April 11, 2016 3:30:00PM"),
                    },

                    // Person Details
                    PersonId = 2,
                    Person = new Person
                    {
                        Id = 2,
                        FirstName = "Hubert",
                        LastName = "Farnsworth",
                        Email = "HFarnsworth@planex.com",
                        Phone = "555.555.5555",
                    }
                },
                new Announcement {
                    Id = 3,
                    Title = "Third Announcement",
                    Message = "The third announcement",
                    IsPriority = false,
                    Type = AnnouncementType.Staff,
                    StartDate = DateTime.Parse("April 13, 2016"),
                    EndDate = DateTime.Parse("April 16, 2016"),
                    DetailsLink = "https://google.com",
                    Attachments = { "https://sf.edu" },

                    // Event Details
                    EventId = 3,
                    Event = new Event
                    {
                        Id = 3,
                        Location = "Somewhere else, but not there",
                        EventDate = DateTime.Parse("April 14, 2016 1:30:00PM"),
                    },

                    // Person Details
                    PersonId = 3,
                    Person = new Person
                    {
                        Id = 3,
                        FirstName = "Philip",
                        LastName = "Fry",
                        Email = "PFry@planex.com",
                        Phone = "555.555.5555",
                    }
                }
            };
        }
        public void Add(ref Announcement announcement)
        {
            announcement.Id = _announcements.Count + 1;
            announcement.EventId = announcement.Id;
            announcement.Event.Id = announcement.Id;
            announcement.PersonId = announcement.Id;
            announcement.Person.Id = announcement.Id;
            _announcements.Add(announcement);
        }

        public IEnumerable<Announcement> GetAll()
        {
            return _announcements;
        }
    }
}
