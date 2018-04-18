using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [DataContract]
    public class Shift
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime Start { get; set; }

        [DataMember]
        public DateTime End { get; set; }

        [DataMember]
        public Employee Employee { get; set; }
        

        public Shift()
        {

        }
        public Shift(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }

        public Shift(int id, DateTime start, DateTime end, Employee employee)
        {
            this.Id = id;
            this.Start = start;
            this.End = end;
            this.Employee = employee;
        }
    }
}
