using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Pages_Abouts
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;

        public IndexModel(SchoolContext context)
        {
            _context = context;
        }


        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList HeadName { get; set; }
         [BindProperty(SupportsGet = true)]
        public string AboutHeadName { get; set; }
        public IList<About> About { get;set; }
        

        

        public async Task OnGetAsync()
        {
            IQueryable<string> HeadNameQuery = from m in _context.About
                                    orderby m.HeadName
                                    select m.HeadName;

            var Abouts = from m in _context.About
                        select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                Abouts = Abouts.Where(s => s.Name.Contains(SearchString));
            }

             if (!string.IsNullOrEmpty(AboutHeadName))
            {
                Abouts = Abouts.Where(x => x.HeadName == AboutHeadName);
            } 
        HeadName = new SelectList(await HeadNameQuery.Distinct().ToListAsync());
             

            About = await Abouts.ToListAsync();
        }
    }
}
