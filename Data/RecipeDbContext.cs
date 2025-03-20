using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class RecipeDbContext : DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
} 