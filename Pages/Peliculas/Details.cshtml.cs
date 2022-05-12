using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cine.Data;
using Cine.Models;

namespace Cine.Pages.Peliculas
{
    public class DetailsModel : PageModel
    {
        private readonly Cine.Data.CineContext _context;

        public DetailsModel(Cine.Data.CineContext context)
        {
            _context = context;
        }

      public Pelicula Pelicula { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pelicula == null)
            {
                return NotFound();
            }

            var pelicula = await _context.Pelicula.FirstOrDefaultAsync(m => m.ID == id);
            if (pelicula == null)
            {
                return NotFound();
            }
            else 
            {
                Pelicula = pelicula;
            }
            return Page();
        }
    }
}
