using ServerSide.Model;
using ServerSide;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Linq;

namespace ServerSide
{
    public class DataController : IDataController
    {
        private readonly CockTailsDBContext db;

        public DataController(CockTailsDBContext db)
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public string CreateDrink(Drink drink, string categoryID)
        {
            //var category = db.Categories.Find(categoryID);
            drink.Category = db.Categories.Find(categoryID);
            db.Add(drink);
            return ("Monke");
        }

        public string RemoveDrink(Drink drink)
        {
            db.Remove(drink);
            return ("Monke");
        }

        public Drink UpdateDrink(Drink drink)
        {
            db.Update(drink);
            return (drink);
        }

        public Drink ReadDrink(string id)
        {
            return db.Drinks.Find(id);
        }

        public IEnumerable<Drink> SearchDrink(string name)
        {
            var query = from d in db.Drinks
                        where d.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby d.Name
                        select d;
            return query;
        }
    }
}
