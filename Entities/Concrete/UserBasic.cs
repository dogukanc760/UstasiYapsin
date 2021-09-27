using System;
using System.Collections.Generic;

#nullable disable

namespace UstasiYapsinAPI.Entities.Concrete
{
    public partial class UserBasic
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public bool? Status { get; set; }
        public int? Type { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Description { get; set; }
        public bool? IsBanned { get; set; }
    }
}
