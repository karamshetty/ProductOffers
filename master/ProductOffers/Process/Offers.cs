using ProductOffers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOffers.Process
{
    public class Offers: IOffers
    {
        public OffersModel getOfferDetails()
        {
            OffersModel obj1 = new OffersModel();
            List<int> lst1 = new List<int>();
            List<string> lst2 = new List<string>();
            List<string> lst3 = new List<string>();

            lst1.Add(10);
            lst2.Add("Test1");
            lst3.Add("Test2");
            obj1.Price = lst1;
            obj1.Name = lst2;
            obj1.OfferDetails = lst2;

            return obj1;
        }
    }
}
