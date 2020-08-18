using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication6.Controllers
{
    public class PrzelicznikController : ApiController
    {

        [HttpGet]
        public double PlnToUsd(double value1)
        {
            return (value1 * 0.27 );
        }

        [HttpGet]
        public double UsdToPln(double value1)
        {
            return (value1 * 3.674036);
        }

        [HttpGet]
        public double PlnToGbp(float value1)
        {
            return (value1 * 0.2059048959);
        }

        [HttpGet]
        public double GbpToPln(double value1)
        {
            return (value1* 4.8566110863);
        }


        [HttpGet]
        public string Get()
        {
            return "default";
        }



    }
}
