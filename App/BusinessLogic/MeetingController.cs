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
        private DBMeeting db = new DBMeeting();
        public IEnumerable<Meeting> All()
        {
            return db.All();
        }

        public void Create(Meeting entity)
        {
            db.Create(entity);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }

        public Meeting Read(int id)
        {
           return db.Read(id);
        }

        public void Update(Meeting entity)
        {
            db.Update(entity);
        }
    }
}
