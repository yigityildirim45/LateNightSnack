using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Models;
using Data;

namespace LateNightSnack.Pages.Recipes
{
    public class DetailsModel : PageModel
    {
        private readonly RecipeDbContext _context;

        public DetailsModel(RecipeDbContext context)
        {
            _context = context;
        }

        public Recipe? Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.Id == id);

            if (Recipe == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
} 