using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Employee : Person
    {

        public Employee()
        {
            
        }
        public Employee(int id)
        {
            this.Id = id;
        }
        public Employee(int id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Email = Email;
        }
    }
}
