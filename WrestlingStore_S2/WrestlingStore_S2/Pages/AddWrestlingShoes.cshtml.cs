using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Modules;

namespace WrestlingStore_S2.Pages
{
    public class AddWrestlingShoesModel : PageModel
    {
        [BindProperty]
        public WrestlingShoes ws { get; set; }



        public ProductManager pm = new ProductManager();

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                pm.AddShoes(ws.prodName, ws.prodCategory, ws.prodPrice, ws.prodImg, ws.KindOfActivity);

                return RedirectToPage("AddWrestlingShoes");

            }
            return Page();
        }
    }
}
