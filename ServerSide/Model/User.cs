using System;
using System.Collections.Generic;
using System.Text;

namespace ServerSide.Model
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Byte[] ProfileImage { get; set; }
    }
}
