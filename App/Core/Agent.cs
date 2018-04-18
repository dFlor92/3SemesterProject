using System;

namespace Core
{
    public class Agent : Person
    {
        public int Phone { get; set; }
        public Agent(string name, int id, string email, int phone)
        {
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.Phone = phone;
        }

        public Agent(string name, int id, string email, Campaign campaign)
        {
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.Phone = Phone;
        }
    }
}
