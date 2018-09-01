using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPMobileLibrary.Database
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public byte[] UserPicture { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string EmpType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Manager { get; set; }

        public bool UseDataOver3G4G { get; set; }
        public bool UserDataOverWiFi { get; set; }
        public string UserLang { get; set; }
    }
}
