using System.Collections.Generic;

namespace USF.Announcements.Entities
{
    public interface IAnnouncementData
    {
        IEnumerable<Announcement> GetAll();
        void Add(ref Announcement announcement);
    }
}
