using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PoC_EFCF_Test.Data;
using PoC_EFCF_Test.Models;

namespace PoC_EFCF_Test.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly PoC_EFCF_Test.Data.PoC_EFCF_TestContext _context;

        public CreateModel(PoC_EFCF_Test.Data.PoC_EFCF_TestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
