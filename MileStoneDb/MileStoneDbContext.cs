using Microsoft.EntityFrameworkCore;
using MileStoneProject.Models;

namespace MileStoneProject.MileStoneDb
{
    public class MileStoneDbContext : DbContext
    {
        public MileStoneDbContext(DbContextOptions<MileStoneDbContext> options) 
            : base(options){}

        public DbSet<Student> Students { get; set; }
        
    }
}