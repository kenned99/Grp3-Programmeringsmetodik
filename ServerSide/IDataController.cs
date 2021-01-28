using System;
using System.Collections.Generic;
using System.Text;
using ServerSide.Model;
using ServerSide;

namespace ServerSide
{
    public interface IDataController
    {
        public int Commit();
        public string CreateDrink(Drink drink);
        public Drink UpdateDrink(Drink drink);
        public Drink ReadDrink(string id);
        public string RemoveDrink(Drink drink);
        public IEnumerable<Drink> SearchDrink(string name);
    }
}
