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
    public class CategoryModel : PageModel
    {
        private readonly IDataController idc;
        
        public CategoryModel(IDataController idc)
        {
            this.idc = idc;
        }

        public List<Drink> drinks = new List<Drink>();

        public void OnGet()
        {
            for (int i = 0; i < 8; i++)
            {
                drinks.Add(idc.ReadDrink(i.ToString()));
            }
        }
    }
}
