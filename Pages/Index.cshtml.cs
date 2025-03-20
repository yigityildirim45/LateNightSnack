using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Data;
using Models;

namespace LateNightSnack.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RecipeDbContext _context;

        public IndexModel(RecipeDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipes { get; set; } = new List<Recipe>();

        public async Task OnGetAsync()
        {
            Recipes = await _context.Recipes
                .OrderByDescending(r => r.CreatedDate)
                .ToListAsync();
        }
    }
} 