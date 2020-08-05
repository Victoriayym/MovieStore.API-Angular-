using MovieStore.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Models
{
    public class AuthResponse
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Token { get; set; }

        public AuthResponse(UserLoginReponseModel user, string token)
        {
            this.Id = user.Id;
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.Email = user.Email;
            this.Token = token;
        }
    }
}
