using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum Role { User, Admin };

    public class SystemUser
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }
        public SystemUser(int id, string name, string email, Role role)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Role = role;

        }

       

    }
}
