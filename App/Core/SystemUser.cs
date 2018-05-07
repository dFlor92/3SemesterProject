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
        public string Phone { get; set; }

        //Maybe rename to HashedPassword?
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Salt { get; set; }

        [DataMember]
        public Role Role { get; set; }

        public SystemUser(int id, string name, string email, string phone, string password, Role role)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Role = role;

        }

        public SystemUser(string email, string password, string salt)
        {
            this.Email = email;
            this.Password = password;
            this.Salt = salt;

        }
    }
}
