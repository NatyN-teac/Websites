using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BHSM.Areas.Admin.Models;

namespace BHSM.Areas.Admin.Controllers.API
{

    public class StaffController : ApiController
    {

        private ApplicationDbContext _context;
        public StaffController()
        {
            _context = new ApplicationDbContext();
        }

        
        public StaffProfile GetStaff(int id) {

            var staff = _context.StaffProfiles.SingleOrDefault(s => s.Id == id);
            if(staff == null) {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return staff;
        }


    [HttpDelete]
    public void DeleteStaff(int id) {
            var staff = _context.StaffProfiles.SingleOrDefault(s => s.Id == id);

            if(staff == null) {
                throw new HttpResponseException(HttpStatusCode.NotFound);

            }

            _context.StaffProfiles.Remove(staff);
            _context.SaveChanges();
    }
    }
}
