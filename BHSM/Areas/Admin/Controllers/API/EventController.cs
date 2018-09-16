using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BHSM.Areas.Admin.ViewModel;

namespace BHSM.Areas.Admin.Controllers.API
{
    public class EventController : ApiController
    {
    public IHttpActionResult CreateEvent(EventViewModel vm) {


            return Ok();
    }

    }
}
