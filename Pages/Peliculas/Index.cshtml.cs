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
    public class IndexModel : PageModel
    {
        private readonly Cine.Data.CineContext _context;

        public IndexModel(Cine.Data.CineContext context)
        {
            _context = context;
        }

        public IList<Pelicula> Pelicula { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pelicula != null)
            {
                Pelicula = await _context.Pelicula.ToListAsync();
            }
        }
    }
}
