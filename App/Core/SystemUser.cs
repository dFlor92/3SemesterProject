using System;
using System.Runtime.Serialization;

namespace Core
{
    public enum Role { User, Admin };
    [DataContract]
    public class SystemUser
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public Role Role { get; set; }

        public SystemUser(int id)
        {
            this.Id = id;
        }
        public SystemUser(int id, string name, string email, Role role)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Role = role;

        }
    }
}
