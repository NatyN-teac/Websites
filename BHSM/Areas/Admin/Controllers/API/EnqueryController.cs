using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BHSM.Areas.Admin.Models;

namespace BHSM.Areas.Admin.Controllers.API
{
    public class EnqueryController : ApiController
    {

    private ApplicationDbContext  _context;
    public EnqueryController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpDelete]
        public void DeleteEnquery(int id)
        {
            var query = _context.EnqueryTables.SingleOrDefault(s => s.Id == id);

            if (query == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);

            }

            _context.EnqueryTables.Remove(query);
            _context.SaveChanges();
        }

    }
}
