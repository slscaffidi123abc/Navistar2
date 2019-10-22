using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OneMoreTime.Data;

namespace OneMoreTime.Pages.Doc
{
    public class IndexModel : PageModel
    {
        private readonly OneMoreTime.Data.ApplicationDbContext _context;

        public IndexModel(OneMoreTime.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Doctors> Doctors { get;set; }

        public async Task OnGetAsync()
        {
            Doctors = await _context.Doctors.ToListAsync();
        }
    }
}
