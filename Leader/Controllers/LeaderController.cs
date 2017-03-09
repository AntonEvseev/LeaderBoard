using Leader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Net.Http.Headers;

namespace Leader.Controllers
{
    public class LeaderController : ApiController
    {
        private LeaderContext db = new LeaderContext();

        [HttpGet]
        public HttpResponseMessage Get()
        {
            List<Gamer> gamers = db.Gamers.Include(x=>x.Game).ToList();
            HttpResponseMessage response;
            response = Request.CreateResponse(HttpStatusCode.OK, gamers, GlobalConfiguration.Configuration.Formatters.JsonFormatter);
            response.Headers.CacheControl = new CacheControlHeaderValue()
            {
                MaxAge = TimeSpan.FromMinutes(2)
            };
            return response;
        }
   }
}
