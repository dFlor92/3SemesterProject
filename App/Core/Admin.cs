using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Admin : Person
    {
        public Admin()
        {

        }
        public Admin(int id)
        {
            this.Id = id;
        }
        public Admin(int id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }
    }
}
