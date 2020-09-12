using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOffers.Model
{
    public class OffersModel
    {
        public IList<int> Price { get; set; }
        public IList<string> Name { get; set; }
        public IList<string> OfferDetails { get; set; }
    }
}
