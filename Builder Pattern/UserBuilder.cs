using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class UserBuilder
    {
        private readonly  User _user = new();
        public UserBuilder setFirstName(string firstName)
        {
            _user.FirstName = firstName;
            return this;
        }
        public UserBuilder setLastName(string lastName)
        {
            _user.LastName = lastName;
            return this;
        }
        public UserBuilder setEmail(string email)
        {
            _user.Email = email;
            return this;
        }
        public User Build()
        {
            return _user;
        }
    }
}
