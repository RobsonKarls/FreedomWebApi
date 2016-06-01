using System;
using System.Linq;
using Freedom.Domain.Entities;
using Freedom.Infrastructure.DataAccess.Factories;
using Freedom.Labs.Components;

namespace Freedom.Infrastructure.DataAccess.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(FreedomDbContext context)
            : base(context)
        {
        }

        public override void Save(User instance)
        {

            if (string.IsNullOrEmpty(instance.Email))
            {
                throw new ArgumentNullException("Email cant be null");
            }

            if (String.IsNullOrEmpty(instance.Password))
            {
                throw new ArgumentNullException("Password cant be null");
            }

            if (Context.Users.Any(u => u.Email == instance.Email && u.Id != instance.Id))
            {
                throw new ArgumentException("Email already exists on database");
            }
           
            base.Save(instance);
        }

        public void ResetPassword(User user, string newPassword)
        {
            user.Password = Password.CreateHashFrom(newPassword);

            Context.MarkAsModified(user);
        }
    }
}
