using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using freeCodeCampCourse.Models;

namespace freeCodeCampCourse.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<freeCodeCampCourse.Models.Joke> Joke { get; set; } = default!;
    }
}
