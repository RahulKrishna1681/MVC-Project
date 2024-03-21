using BookDash.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;

namespace BookDash.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<FormDataa> FormDatas { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
