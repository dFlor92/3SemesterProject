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
        public IEnumerable<Meeting> All()
        {
            throw new NotImplementedException();
        }

        public void Create(Meeting entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Meeting Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Meeting entity)
        {
            throw new NotImplementedException();
        }
    }
}
