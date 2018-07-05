using OIDModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OIDWebManager.Controllers
{
    public class OIDController : Controller
    {
        private OID oid = new OID();
        
        // GET: OID
        public ActionResult Index()
        {
            oid.ID = 1;
            oid.Parent = 0;
            oid.Number = 123;
            oid.Identifier = "oid test";
            oid.OtherIdentifiers = "other oid test";
            oid.Description = "description";
            oid.Information = "info";
            return View(oid);
        }

    }
}
