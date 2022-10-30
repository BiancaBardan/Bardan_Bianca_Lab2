using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bardan_Bianca_Lab2.Data;
using Bardan_Bianca_Lab2.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace Bardan_Bianca_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Bardan_Bianca_Lab2.Data.Bardan_Bianca_Lab2Context _context;

        public CreateModel(Bardan_Bianca_Lab2.Data.Bardan_Bianca_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
