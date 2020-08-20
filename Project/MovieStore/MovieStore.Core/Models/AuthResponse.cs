using MovieStore.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Models
{
    public class AuthResponse
    {
        public UserLoginReponseModel User { get; set; }
        

        public string Token { get; set; }

        public AuthResponse(UserLoginReponseModel user, string token)
        {
            this.User=user;
            this.Token = token;
        }
    }
}
