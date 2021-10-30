using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorpagesfromTimecory1.Models;

namespace RazorpagesfromTimecory1.Pages
{
    public class MyInfoModel : PageModel
    {
        [BindProperty]
        public MyInfoModel MyDataInfos { get; set; }
        

        public void OnGet()
        {


        }

        public IActionResult Onpost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            else  return RedirectToPage("/privacy");



        }

    }
}
