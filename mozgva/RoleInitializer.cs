using mozgva.Models;  // пространство имен модели User
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using mozgva.Data;

namespace mozgva
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<AspNetUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string adminEmail = "admin@mail.com";
            string password = "Admin1&";
            
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("employee") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("employee"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                AspNetUser admin = new AspNetUser { Email = adminEmail, UserName = adminEmail,EmailConfirmed=true };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}