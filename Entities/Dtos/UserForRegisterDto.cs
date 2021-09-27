﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserForRegisterDto:IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gsm { get; set; }
        public bool Status { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public bool IsBanned { get; set; }
    }
}
