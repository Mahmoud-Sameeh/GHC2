using GHC2.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHC2.Models
{
    [ViewComponent]
    public class VCViewComponent: ViewComponent
    {
        [BindProperty]
        public Doctor Doctor { get; set; }
        public ApplicationDbContext db { get; set; }

        public VCViewComponent(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke(Doctor Doctor)
        {

            return View("Defaul");
        }



    }
    [ViewComponent]

    public class DRegistration : ViewComponent
    {
        [BindProperty]
        public Doctor Doctor { get; set; }
        public ApplicationDbContext db { get; set; }
       
        public DRegistration(ApplicationDbContext _db)
        {
            db = _db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return  View(@"Default.cshtml");
        }

    }

}
