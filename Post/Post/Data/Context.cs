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
        public DbSet<Users> Users { get; set; }
     }
}
