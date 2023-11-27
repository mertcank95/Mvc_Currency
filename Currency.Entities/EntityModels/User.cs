using Currency.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Currency.Entities.EntityModels
{
    public class User : IdentityUser
    {
        public String? Name { get; set; }
        public String? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public UserGender Gender { get; set; }
        public bool IsActive { get; set; }
        public int Amount { get; set; }
        public String? EmailVertificationCode { get; set; }

    }


}
