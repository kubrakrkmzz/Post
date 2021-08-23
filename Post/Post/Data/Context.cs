using Microsoft.EntityFrameworkCore;
using Post.Models;

namespace Post.Data
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions <Context> options)
            : base(options) 
        { 
        }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
