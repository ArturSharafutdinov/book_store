using book_store.Models.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Jwt
{
    public class JwtResponse
    {
        public string token { get; private set; }
        public string type = "Bearer";
       public UserDto user { get; set; }

        public JwtResponse(string token,  UserDto user)
        {
            this.token = token;
            this.user = user;
        }
    }
}
