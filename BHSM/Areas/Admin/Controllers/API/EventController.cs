using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BHSM.Areas.Admin.Models;
using BHSM.Areas.Admin.ViewModel;



namespace BHSM.Areas.Admin.Controllers.API
{
   
    public class EventController : ApiController
    {

        private ApplicationDbContext _context;

        public EventController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public void DeleteEvent(int id)
        {
            var eve = _context.Events.SingleOrDefault(s => s.Id == id);

            if (eve == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);

            }

            _context.Events.Remove(eve);
            _context.SaveChanges();
        }

    }
}
