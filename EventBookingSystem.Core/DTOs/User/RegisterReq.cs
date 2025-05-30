﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBookingSystem.Core.DTOs.Auth
{
    public class RegisterReq
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateOnly Birthaday { get; set; }
    }
}
