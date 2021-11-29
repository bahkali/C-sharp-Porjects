using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();
        // GET: Admin
        public ActionResult Index()
        {
            var insurees = db.Insurees;
            var insureeVms = new List<InsureeVm>();
            foreach (var insuree in insurees)
            {
                var insureVm = new InsureeVm();
                insureVm.FirstName = insuree.FirstName;
                insureVm.LastName = insuree.LastName;
                insureVm.EmailAddress = insuree.EmailAddress;
                insureVm.Quote = insuree.Quote;
                insureeVms.Add(insureVm);
            }
            return View(insureeVms);
        }
    }
}