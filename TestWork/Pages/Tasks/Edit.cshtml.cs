using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgileWorks.Data;
using AgileWorks.Infra;

namespace TestWork.Pages.Tasks
{
    public class EditModel : PageModel
    {
        private readonly AgileWorks.Infra.ApDbContext _context;

        public EditModel(AgileWorks.Infra.ApDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TaskData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskDataExists(TaskData.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TaskDataExists(string id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }
    }
}
