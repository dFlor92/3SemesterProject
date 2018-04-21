using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Core;

namespace BusinessLogic
{
    public class MeetingController : IDatabaseCRUD<Meeting>
    {
        DBMeeting dbMeeting = new DBMeeting();
        public IEnumerable<Meeting> All()
        {
            return dbMeeting.All();
        }

        public void Create(Meeting entity)
        {
            dbMeeting.Create(entity);
        }

        public void Delete(int id)
        {
            dbMeeting.Delete(id);
        }

        public Meeting Read(int id)
        {
           return dbMeeting.Read(id);
        }

        public void Update(Meeting entity)
        {
            dbMeeting.Update(entity);
        }
    }
}
