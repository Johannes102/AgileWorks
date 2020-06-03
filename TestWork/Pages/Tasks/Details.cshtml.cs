using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgileWorks.Data;
using AgileWorks.Infra;

namespace TestWork.Pages.Tasks
{
    public class DetailsModel : PageModel
    {
        private readonly AgileWorks.Infra.ApDbContext _context;

        public DetailsModel(AgileWorks.Infra.ApDbContext context)
        {
            _context = context;
        }

        public TaskData TaskData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TaskData = await _context.Tasks.FirstOrDefaultAsync(m => m.Id == id);

            if (TaskData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
