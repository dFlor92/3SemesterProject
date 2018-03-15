using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using Core;
using DataAccesLayer;

namespace NobiService
{
    public class Service : IService
    {
        private ICRUD<Shift> controller;

        public Service()
        {
            controller = new ShiftController();
        }
        public void Create(Shift entity)
        {
            controller.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Shift Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shift entity)
        {
            throw new NotImplementedException();
        }
    }
}
