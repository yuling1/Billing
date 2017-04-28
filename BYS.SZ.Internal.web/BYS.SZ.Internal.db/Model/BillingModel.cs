using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Model
{
    public class BillingModel
    {
        public string SOW { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        [ColumnName("Onboard Date")]
        public string OnboardDate { get; set; }
        public string Location { get; set; }
        public string Title { get; set; }
        public string Owner { get; set; }
        [ColumnName("Work date")]
        public int Workdate { get; set; }
        public float Rate { get; set; }
        public int Salary { get; set; }
        public string MetaData { get; set; }
    }
}
