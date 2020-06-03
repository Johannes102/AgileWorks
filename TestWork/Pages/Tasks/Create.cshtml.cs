using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AgileWorks.Data;
using AgileWorks.Infra;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Microsoft.AspNetCore.Diagnostics;
using System.IO;

namespace TestWork.Pages.Tasks
{
    public class CreateModel : PageModel
    {
        private readonly ApDbContext _context;

        public CreateModel(ApDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TaskData Task { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Task.Id = Guid.NewGuid().ToString();
            Task.ValidFrom = DateTime.Now;

            if (Task.ValidTo <= DateTime.Now)
            {
                return Page();
            }

            _context.Tasks.Add(Task);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
