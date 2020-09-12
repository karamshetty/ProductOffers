using ProductOffers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOffers.Process
{
    public interface IOffers
    {
        OffersModel getOfferDetails();
    }
}
