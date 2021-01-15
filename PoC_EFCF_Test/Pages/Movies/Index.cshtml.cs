using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PoC_EFCF_Test.Data;
using PoC_EFCF_Test.Models;

namespace PoC_EFCF_Test.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly PoC_EFCF_Test.Data.PoC_EFCF_TestContext _context;

        public IndexModel(PoC_EFCF_Test.Data.PoC_EFCF_TestContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
