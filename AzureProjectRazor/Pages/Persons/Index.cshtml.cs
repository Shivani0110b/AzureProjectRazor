using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AzureProjectRazor.Data;

namespace AzureProjectRazor.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly AzureProjectRazor.Data.AppDbContext _context;

        public IndexModel(AzureProjectRazor.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
