﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHSM.Controllers
{
    public class TrainingsController : Controller
    {
        // GET: Trainings
        public ActionResult facultyTraining()
        {
            return View();
        }
    }
}