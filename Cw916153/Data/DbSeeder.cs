using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw916153.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Cw916153.Data
{
    public static class DbSeeder
    {
        public static async Task SeedDbAsync(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            await seedRoleDb(context, userManager, roleManager);
            await SeedUserDb(context, userManager, roleManager);
            await SeedUserToRoles(context, userManager, roleManager);

        }

        public static async Task seedRoleDb(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();
            string[] roles = { "canCreateComment", "canUseModuleControls", "canUsePostControls" };

            foreach (var r in roles)
            {
                if (await roleManager.FindByNameAsync(r) == null)
                {
                    await roleManager.CreateAsync(new ApplicationRole(r));
                }
            }

        }

        public static async Task SeedUserDb(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            Module mod1 = new Module
            {
                Name = "Module 1"

            };

            Module mod = context.Module.FirstOrDefault(x => x.Name == mod1.Name);

            if (mod == null)
            {
                await context.Module.AddAsync(mod1);
            }

            string[] users = { "Admin@email.com", "Member1@email.com", "Customer1@email.com", "Customer2@email.com",
                "Customer3@email.com", "Customer4@email.com", "Customer5@email.com"};
            string password = "Password123!";

            foreach (var user in users)
            {
                if (await userManager.FindByNameAsync(user) == null)
                {
                    var u = new ApplicationUser
                    {
                        UserName = user,
                        Email = user
                    };


                    var result = await userManager.CreateAsync(u);

                    if (result.Succeeded)
                    {
                        await userManager.AddPasswordAsync(u, password);                   
                        var a1 = await userManager.FindByNameAsync(u.UserName);
                        //await userManager.AddToRoleAsync(a1, "canEditUser");
                    }

                }
            }
        }

        public static async Task SeedUserToRoles(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
            RoleManager<ApplicationRole> roleManager)
        {

            var r1 = await roleManager.FindByNameAsync("canUseModuleControls");
            var r2 = await roleManager.FindByNameAsync("canUsePostControls");
            var r3 = await roleManager.FindByNameAsync("canCreateComment");

            var a1 = await userManager.FindByNameAsync("Admin@email.com");
            var m1 = await userManager.FindByNameAsync("Member1@email.com");
            var c1 = await userManager.FindByNameAsync("Customer1@email.com");
            var c2 = await userManager.FindByNameAsync("Customer2@email.com");
            var c3 = await userManager.FindByNameAsync("Customer3@email.com");
            var c4 = await userManager.FindByNameAsync("Customer4@email.com");
            var c5 = await userManager.FindByNameAsync("Customer5@email.com");

            List<IdentityUserRole<string>> usersWithRoles = new List<IdentityUserRole<string>>();

            //Admin Roles
            IdentityUserRole<string> a1r1 = new IdentityUserRole<string>();
            a1r1.RoleId = r1.Id;
            a1r1.UserId = a1.Id;
            usersWithRoles.Add(a1r1);

            //Member Roles
            IdentityUserRole<string> m1r5 = new IdentityUserRole<string>();
            m1r5.UserId = m1.Id;
            m1r5.RoleId = r2.Id;
            usersWithRoles.Add(m1r5);

            //Customer Roles
            IdentityUserRole<string> c1r8 = new IdentityUserRole<string>();
            c1r8.UserId = c1.Id;
            c1r8.RoleId = r3.Id;
            usersWithRoles.Add(c1r8);
            IdentityUserRole<string> c2r8 = new IdentityUserRole<string>();
            c2r8.UserId = c2.Id;
            c2r8.RoleId = r3.Id;
            usersWithRoles.Add(c2r8);
            IdentityUserRole<string> c3r8 = new IdentityUserRole<string>();
            c3r8.UserId = c3.Id;
            c3r8.RoleId = r3.Id;
            usersWithRoles.Add(c3r8);
            IdentityUserRole<string> c4r8 = new IdentityUserRole<string>();
            c4r8.UserId = c4.Id;
            c4r8.RoleId = r3.Id;
            usersWithRoles.Add(c4r8);
            IdentityUserRole<string> c5r8 = new IdentityUserRole<string>();
            c5r8.UserId = c5.Id;
            c5r8.RoleId = r3.Id;
            usersWithRoles.Add(c5r8);

            foreach (var uRole in usersWithRoles)
            {
                IdentityUserRole<string> tableItem = context.UserRoles.FirstOrDefault
                    (x => x == uRole);
                if (tableItem == null)
                {
                    await context.UserRoles.AddAsync(uRole);
                }
            }

            //context.UserRoles.Add(add2);
            await context.SaveChangesAsync();

        }

    }
}
