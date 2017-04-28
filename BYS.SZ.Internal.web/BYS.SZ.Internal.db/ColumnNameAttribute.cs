using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db
{
    public class ColumnNameAttribute : Attribute
    {
        private string name;
        public ColumnNameAttribute(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
        }
    }
}
