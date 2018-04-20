using System;
using System.Runtime.Serialization;

namespace Core
{
    [DataContract]
    public class Campaign
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }


        public Campaign(string name, string description)
        {
            this.Name = name;
            this.Description = description;

        }

        public Campaign(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
