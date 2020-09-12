using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductOffers.Model;
using ProductOffers.Process;

namespace ProductOffers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private IOffers _offers;
        public OffersController(IOffers Offers)
        {
            _offers = Offers;
        }
        [HttpGet]
        [Route("~/api/getOffers")]
        public OffersModel GetOffers()
        {
            return _offers.getOfferDetails();
        }

    }
}
