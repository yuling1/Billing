using BYS.SZ.Internal.db.Model;
using BYS.SZ.Internal.portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BYS.SZ.Internal.portal.Controllers
{
    public class DetailController : Controller
    {
        public ActionResult Billing()
        {
            List<BillingModel> list = new List<BillingModel>();

            BillingModel billing1 = new BillingModel
            {
                SOW = "ASG Cortana/Carina dev",
                Name = "郁霖",
                Alias = "v-yln",
                OnboardDate = DateTime.Now.AddYears(-1),
                Location = "Suzhou OF",
                Title = "SDE Lead",
                Workdate = 168,
                Rate = 1,
                Salary = 3000,
                MetaData = "Total: $168 S/R: 91%"
            };
            BillingModel billing2 = new BillingModel
            {
                SOW = "ASG Cortana/Carina dev",
                Name = "亢晓江",
                Alias = "v-xikan",
                OnboardDate = DateTime.Now.AddYears(-1),
                Location = "Suzhou OF",
                Title = "PM 3",
                Workdate = 168,
                Rate = 1,
                Salary = 3000,
                MetaData = "Total: $168 S/R: 91%"
            };
            BillingModel billing3 = new BillingModel
            {
                SOW = "ASG Cortana/Carina dev",
                Name = "窦素娥",
                Alias = "v-suedou",
                OnboardDate = DateTime.Now.AddYears(-1),
                Location = "Suzhou OF",
                Title = "SDE 2",
                Workdate = 168,
                Rate = 1,
                Salary = 3000,
                MetaData = "Total: $168 S/R: 91%"
            };
            BillingModel billing4 = new BillingModel
            {
                SOW = "ASG Cortana/Carina dev",
                Name = "徐培",
                Alias = "v-peix",
                OnboardDate = DateTime.Now.AddYears(-1),
                Location = "Suzhou OF",
                Title = "SDE 2",
                Workdate = 168,
                Rate = 1,
                Salary = 3000,
                MetaData = "Total: $168 S/R: 91%"
            };

            list.Add(billing1);
            list.Add(billing2);
            list.Add(billing3);
            list.Add(billing4);


            return View("_Billing", list);
        }
      
    }
}