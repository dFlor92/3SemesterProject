using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {

        }
        public Employee(int id)
        {
            this.Id = id;
        }
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
