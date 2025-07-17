using Buoi10_TranMinhThanh.Models;
using Microsoft.EntityFrameworkCore;

namespace Buoi10_TranMinhThanh.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
    }
}
