using ThesisManagement.Models;
using ThesisManagement.Models.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace ThesisManagement.Data
{
    public static class ApplicationDbContextSeed
    {

        public static async Task SeedIdentityRolesAsync(RoleManager<MyIdentityRole> rolefaculty)
        {
            foreach (IdentityRoles role in Enum.GetValues(typeof(IdentityRoles)))
            {
                string rolename = role.ToString();
                if (!await rolefaculty.RoleExistsAsync(rolename))
                {
                    await rolefaculty.CreateAsync(
                        new MyIdentityRole { Name = rolename });
                }
            }
        }


        public static async Task SeedIdentityUserAsync(UserManager<MyIdentityUser> userfaculty)
        {
            MyIdentityUser user;

            user = await userfaculty.FindByNameAsync("admin@guniuni.com");
            if (user == null)
            {
                user = new MyIdentityUser()
                {
                    UserName = "admin@guniuni.com",
                    Email = "admin@guniuni.com",
                    EmailConfirmed = true,
                    DisplayName = "The Admin User",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    
                };
                await userfaculty.CreateAsync(user, password: "Password@123");
                await userfaculty.AddToRolesAsync(user, new string[] {
                    IdentityRoles.Administrator.ToString(),
                    IdentityRoles.Faculty.ToString()
                });
            }

            user = await userfaculty.FindByNameAsync("faculty@guniuni.com");
            if (user == null)
            {
                user = new MyIdentityUser()
                {
                    UserName = "faculty@guniuni.com",
                    Email = "faculty@guniuni.com",
                    EmailConfirmed = true,
                    DisplayName = "The Faculty",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    
                };
                await userfaculty.CreateAsync(user, password: "Asdf@123");
                await userfaculty.AddToRolesAsync(user, new string[] {
                    IdentityRoles.Faculty.ToString()
                });
            }

        }

    }
}