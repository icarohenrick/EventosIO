using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Tests.API.IntegrationTests.DTO
{
    public class UsuarioJsonDTO
    {
        public bool success { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public User user { get; set; }
    }

    public class User
    {
        public Claim[] claims { get; set; }
        public string id { get; set; }
        public string userName { get; set; }
        public string normalizedUserName { get; set; }
        public string email { get; set; }
        public string normalizedEmail { get; set; }
        public bool emailConfirmed { get; set; }
        public string passwordHash { get; set; }
        public string securityStamp { get; set; }
        public string concurrencyStamp { get; set; }
        public object phoneNumber { get; set; }
        public bool phoneNumberConfirmed { get; set; }
        public bool twoFactorEnabled { get; set; }
        public object lockoutEnd { get; set; }
        public bool lockoutEnabled { get; set; }
        public int accessFailedCount { get; set; }
    }

    public class Claim
    {
        public string issuer { get; set; }
        public string originalIssuer { get; set; }
        public Properties properties { get; set; }
        public object subject { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public string valueType { get; set; }
    }

    public class Properties
    {
    }
}
