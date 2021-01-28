using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServerSide;
using ServerSide.Model;

namespace Grp3_Programmeringsmetodik.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IDataController idc;

        public CreateModel(IDataController idc)
        {
            this.idc = idc;
        }
        [BindProperty]
        public Drink drink { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {     
            idc.CreateDrink(drink, Request.Form["categoryID"]);
            idc.Commit();
        }
    }
}
