using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bardan_Bianca_Lab2.Data;
using Bardan_Bianca_Lab2.Models;

namespace Bardan_Bianca_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Bardan_Bianca_Lab2.Data.Bardan_Bianca_Lab2Context _context;

        public IndexModel(Bardan_Bianca_Lab2.Data.Bardan_Bianca_Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
