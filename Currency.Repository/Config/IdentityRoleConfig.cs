using Currency.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Repository.Config
{
    public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var identityRoles = new List<IdentityRole>();
            foreach (UserRole role in (UserRole[])Enum.GetValues(typeof(UserRole)))
            {
                identityRoles.Add(new IdentityRole() { Name = role.ToString(), NormalizedName = role.ToString().ToUpper() });
            }
            builder.HasData(identityRoles);             
        }
    }
}
