using Microsoft.EntityFrameworkCore;
using Hillel_C_sharp_pro_homework_11.Models;

namespace Hillel_C_sharp_pro_homework_11.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
