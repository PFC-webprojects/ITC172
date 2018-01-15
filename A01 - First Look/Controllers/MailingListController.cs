using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A01___First_Look.Models;


namespace A01___First_Look.Controllers
{
    public class MailingListController : Controller
    {
        // GET: MailingList
        public ActionResult Index()
        {
            MailingList m1 = new MailingList();
            m1.FirstName = "Steve";
            m1.LastName = "Conger";
            m1.EMail = "steven.conger@seattlecolleges.edu";

            MailingList m2 = new MailingList();
            m2.FirstName = "Normal";
            m2.LastName = "Mailer";
            m2.EMail = "norm@gmail.com";

            MailingList m3 = new MailingList();
            m3.FirstName = "Sarah";
            m3.LastName = "Jones";
            m3.EMail = "sarah@gmail.com";

            List<MailingList> mailings = new List<MailingList>();  //  This is a a <generic>.  List is like an array, only it must be one-dimensional.

            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);


            return View(mailings);  //  Must pass the List to the View in order to see it.
        }
    }
}