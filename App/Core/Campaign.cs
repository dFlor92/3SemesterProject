﻿using System;

namespace Core
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
