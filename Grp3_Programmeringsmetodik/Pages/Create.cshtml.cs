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
            List<Ingredient> ingredients = new List<Ingredient>();
            for (int i = 0; i < Request.Form["amount[]"].Count(); i++)
            {
                ingredients.Add(new Ingredient() { 
                    Amount = Convert.ToDouble(Request.Form["amount[]"][i]), 
                    Unit = Request.Form["unit[]"][i],
                    Title = Request.Form["title[]"][i]
                });
            }
            drink.Ingredients = ingredients;
            idc.CreateDrink(drink, Request.Form["categoryID"]);
            idc.Commit();
        }
    }
}
