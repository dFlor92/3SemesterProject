using System;

namespace Core
{
    public class Campaign
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public Campaign(string name, string description)
        {
            this.Name = name;
            this.Description = description;

        }
    }
}
