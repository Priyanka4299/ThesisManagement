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
            foreach (MyIdentityRoleNames role in Enum.GetValues(typeof(MyIdentityRoleNames)))
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

            user = await userfaculty.FindByNameAsync("admin@uni.com");
            if (user == null)
            {
                user = new MyIdentityUser()
                {
                    UserName = "admin@uni.com",
                    Email = "admin@uni.com",
                    EmailConfirmed = true,
                    DisplayName = "The Admin User",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    Gender = MyIdentityGenders.Female
                    
                };
                await userfaculty.CreateAsync(user, password: "Password@123");
                await userfaculty.AddToRolesAsync(user, new string[] {
                    MyIdentityRoleNames.Administrator.ToString(),
                    MyIdentityRoleNames.Faculty.ToString()
                });
            }

            user = await userfaculty.FindByNameAsync("faculty@uni.com");
            if (user == null)
            {
                user = new MyIdentityUser()
                {
                    UserName = "faculty@uni.com",
                    Email = "faculty@uni.com",
                    EmailConfirmed = true,
                    DisplayName = "The Faculty",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    Gender = MyIdentityGenders.Female

                };
                await userfaculty.CreateAsync(user, password: "Asdf@123");
                await userfaculty.AddToRolesAsync(user, new string[] {
                    MyIdentityRoleNames.Faculty.ToString()
                });
            }

        }

    }
}