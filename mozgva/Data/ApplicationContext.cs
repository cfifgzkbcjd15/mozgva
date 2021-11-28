using mozgva.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace mozgva.Data
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
          //Database.EnsureDeleted();   // ������� �� �� ������ ������
          //Database.EnsureCreated();   // ������� �� � ����� ������
        }
    }
}