using System;

namespace Core
{
    public class Agent
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Phone { get; set; }

        public Campaign Campaign { get; set; }

        public String Email { get; set; }
        //public Agent(int id, string name, string email, int phone)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.Email = email;
        //    this.Phone = phone;
        //}

        public Agent(int id, string name, string email, Campaign campaign)
        {
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.Phone = Phone;
        }

        public Agent(int id, string name, string email, int campaignId)
        {
            this.Name = name;
            this.Id = id;
            this.Email = email;
            this.Phone = Phone;
            
        }
    }
}
