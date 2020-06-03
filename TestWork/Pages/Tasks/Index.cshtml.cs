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
    public class IndexModel : PageModel
    {
        private readonly ApDbContext _context;

        public IndexModel(ApDbContext context)
        {
            _context = context;
        }

        public IList<TaskData> TaskData { get;set; }

        public async Task OnGetAsync()
        {
            TaskData = await _context.Tasks.ToListAsync();

            TaskData = TaskData.OrderBy(x => x.ValidTo).ToList();
        }
    }
}
