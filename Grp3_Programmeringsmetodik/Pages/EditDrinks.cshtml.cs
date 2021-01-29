using ServerSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grp3_Programmeringsmetodik.Pages
{
    public class EditDrinksModel : PageModel
    {
        private readonly IDataController idc;
        public EditDrinksModel(IDataController idc) 
        {
            this.idc = idc;
        }
        public void OnGet(string drinkId)
        {
            idc.ReadDrink(drinkId);
        }
    }
}
