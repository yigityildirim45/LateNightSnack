using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Data;

namespace LateNightSnack.Pages.Recipes
{
    public class CreateModel : PageModel
    {
        private readonly RecipeDbContext _context;

        public CreateModel(RecipeDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recipe Recipe { get; set; } = new Recipe();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Recipes.Add(Recipe);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
} 