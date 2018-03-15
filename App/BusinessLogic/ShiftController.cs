using Core;
using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ShiftController : ICRUD<Shift>
    {
        private ICRUD<Shift> shifts;
        public ShiftController()
        {
            shifts = new DBShift();
        }
        public void Create(Shift entity)
        {
            shifts.Create(entity);
        }

        public void Delete(int id)
        {
            shifts.Delete(id);
        }

        public Shift Read(int id)
        {
            return shifts.Read(id);
        }

        public void Update(Shift entity)
        {
            shifts.Update(entity);
        }
    }
}
