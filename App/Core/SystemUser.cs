using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class SystemUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public enum Role {User, Admin};

        public SystemUser(string name, string email, Role role)
        {
            this.Name = name;
            this.Email = email;
            
        }


    }

