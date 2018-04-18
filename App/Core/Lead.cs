using System;

namespace Core
{
    public class Lead
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }

        public Lead(string name, string telephone, string address)
        {
            this.Name = name;
            this.Telephone = telephone;
            this.Address = address;
        }
        public Lead(int id, string name, string telephone, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Telephone = telephone;
            this.Address = address;
        }
    }
}
