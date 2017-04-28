using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Entities
{
    [Table("BillingInfo")]
    public class BillingInfo : DBBase
    {
        public Employee_Basic Employee { get; set; }
        public SOW Billing_SOW { get; set; }
        public DateTime BillingMonth { get; set; } = DateTime.Now;
        
    }
    [Table("Employee_Cost")]
    public class Employee_Cost : DBBase
    {
        public DateTime Month { get; set; }
        public double Salary { get; set; }
        public Employee_Basic EmployeeInfo { get; set; }
        public string MetaData { get; set; }
    }
    [Table("MSTitle")]
    public class MSTitle : DBBase
    {
        [Required]
        public string MicroTitle { get; set; }
        public double Rate { get; set; }
        public int BillingYear { get; set; }
    }
    [Table("SOW")]
    public class SOW : DBBase
    {
        [Required]
        [ColumnName("SOW")]
        public string SOWName { get; set; }
        public DateTime StartData { get; set; } = DateTime.Now.AddYears(-1);
        public DateTime EndData { get; set; } = DateTime.Now;
        [ColumnName("Owner")]
        public string FTEOwnerAlias { get; set; }
        public string Type { get; set; }
    }
}
