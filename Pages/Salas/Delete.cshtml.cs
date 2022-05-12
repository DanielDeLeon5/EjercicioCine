using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cine.Data;
using Cine.Models;

namespace Cine.Pages.Salas
{
    public class DeleteModel : PageModel
    {
        private readonly Cine.Data.CineContext _context;

        public DeleteModel(Cine.Data.CineContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Sala Sala { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sala == null)
            {
                return NotFound();
            }

            var sala = await _context.Sala.FirstOrDefaultAsync(m => m.Id == id);

            if (sala == null)
            {
                return NotFound();
            }
            else 
            {
                Sala = sala;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Sala == null)
            {
                return NotFound();
            }
            var sala = await _context.Sala.FindAsync(id);

            if (sala != null)
            {
                Sala = sala;
                _context.Sala.Remove(Sala);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
