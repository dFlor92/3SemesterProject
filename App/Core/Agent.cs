using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Core
{
    [DataContract]
    public class Agent
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public String Phone { get; set; }

        [DataMember]
        public Campaign Campaign { get; set; }

        [DataMember]
        public String Email { get; set; }

        public Agent(int id, string name, string email, string phone, Campaign campaign)
        {
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.Phone = phone;
            this.Campaign = campaign;
        }
    }
}
