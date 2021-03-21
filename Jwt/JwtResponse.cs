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
        public string account { get; private set; }
        public string name { get; private set; }
        public string role { get; private set; }

        public JwtResponse(string token, string account, string name, string role)
        {
            this.token = token;
            this.account = account;
            this.name = name;
            this.role = role;
        }

    }
}
