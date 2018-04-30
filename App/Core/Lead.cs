using System;
using System.Runtime.Serialization;

namespace Core
{
    public enum LeadStatus
    {
        NotCalled, Called
    }
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

        [DataMember]
        public LeadStatus Status { get; set; }

        [DataMember]
        public string Comment { get; set; }


        public Lead(int id, string name, string phone, string address, LeadStatus status, string comment)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
            this.Status = status;
            this.Comment = comment;
        }
    }
}
