using System;

namespace DotNetCore.Base.Domain.Models
{
    public class User : BaseModel
    {
        public String Name { get; set; }
        public String Password { get; set; }
        public String Role { get; set; }
        public String Token { get; set; }

        public User() : base()
        {
        }

        public User(User model) : base(model)
        {
            if (model == null)
                return;

            Name = model.Name;
            Password = model.Password;
            Role = model.Role;
            Token = model.Token;
        }
    }
}