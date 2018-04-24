using System;
using System.Runtime.Serialization;

namespace Core
{
    [DataContract]
    public class Lead
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Address { get; set; }
      
        public Lead(int id, string name, string phone, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }
    }
}
