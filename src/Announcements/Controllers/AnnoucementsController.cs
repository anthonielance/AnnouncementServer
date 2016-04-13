using System.Linq;
using Microsoft.AspNet.Mvc;
using USF.Announcements.Entities;
using USF.Announcements.ViewModels;

namespace USF.Announcements.Controllers.api
{
    [Route("api/[controller]")]
    public class AnnouncementsController : Controller
    {
        private IAnnouncementData _announcements;

        public AnnouncementsController(IAnnouncementData announcements)
        {
            _announcements = announcements;
        }

        // GET: api/announcements
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_announcements.GetAll());
        }

        // GET: api/announcements/3
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_announcements.GetAll().Where(a => a.Id == id).FirstOrDefault());
        }

        // POST: api/announcements
        [HttpPost]
        public IActionResult Post([FromBody]AnnouncementViewModel model)
        {
            if (ModelState.IsValid)
            {
                var announcement = new Announcement()
                {
                    Type = model.Type,
                    IsPriority = model.IsPriority,
                    Title = model.Title,
                    Message = model.Message,
                    StartDate = model.StartDate,
                    EndDate = model.EndDate,
                    DetailsLink = model.DetailsLink,
                    Attachments = model.Attachments,

                    // Person Details
                    Person = new Person
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        Phone = model.Phone,
                    }
                };

                // Event Details
                if (model.IsEvent)
                {
                    announcement.Event = new Event
                    {
                        Location = model.Location,
                        EventDate = model.EventDate,
                    };
                }

                _announcements.Add(ref announcement);

                return Created($"/api/announcements/{announcement.Id}", announcement);
            }

            var errors = ModelState.Values.ToList();

            return HttpBadRequest(errors);
        }

        // PUT: api/announcements/3
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]AnnouncementViewModel model)
        {
            var announcement = _announcements.GetAll()
                .Where(a => a.Id == id)
                .FirstOrDefault();

            if(announcement != null)
            {
                //TODO: Modify announcement

                return Ok(announcement);
            }

            return HttpNotFound();
        }
    }
}
