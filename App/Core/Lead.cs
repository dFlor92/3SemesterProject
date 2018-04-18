using System;

namespace Core
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Lead(string name, string phone, string address)
        {
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }
        public Lead(int id, string name, string phone, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.Address = address;
        }
    }
}
