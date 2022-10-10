using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Security.Entities;
using Core.Security.Enums;

namespace Domain.Entities
{
    public class AppUser : User
    {
        public string GithubLink { get; set; }

        public AppUser():base()
        {
            
        }

        public AppUser(int id, string firstName, string lastName, string email, string githubLink, Byte[] passwordHash, Byte[] passwordSalt, Boolean status, AuthenticatorType authenticatorType) : base(id,firstName,lastName,email,passwordSalt,passwordHash, status, authenticatorType)
        {
        }
    }
}
