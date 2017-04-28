using BYS.SZ.Internal.db.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BYS.SZ.Internal.portal.Models
{
    public class BillingListModel
    {
        public IEnumerable<BillingModel> BillingList { get; set; }
    }
}