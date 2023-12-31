﻿using Currency.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Entities.Dtos
{
    public class UserRegistrationDto
    {
        public String? UserName { get; set; }
        public String? Surname { get; set; }
        public String? Email { get; set; }
        public String? PhoneNumber { get; set; }
        public String? Password { get; set; }
        public UserGender Gender { get; set; }
    }



}
