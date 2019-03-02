using System;

namespace Models
{
    public class User
    {
        public string Id { set; get; }
        public string Email { set; get; }
        public string HashedPassword { set; get; }

        public User()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
