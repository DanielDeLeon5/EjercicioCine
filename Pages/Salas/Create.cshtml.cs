using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cine.Data;
using Cine.Models;

namespace Cine.Pages.Salas
{
    public class CreateModel : PageModel
    {
        private readonly Cine.Data.CineContext _context;

        public CreateModel(Cine.Data.CineContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sala Sala { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Sala == null || Sala == null)
            {
                return Page();
            }

            _context.Sala.Add(Sala);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
