using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.Entities
{
    [Table("Employee_Basic")]
    public class Employee_Basic : DBBase
    {
        [Required]
        [ColumnName("Name")]
        public string UserName { get; set; }
        [ColumnName("Alias")]
        public string UserAlias { get; set; }
        public MSTitle UserMSTitle { get; set; }
        [Required]
        public int BeyondSoftID { get; set; }
        [Required]
        public string UserRole { get; set; }
        public string Email { get; set; }
    }

    public class DBBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
