using BYS.SZ.Internal.db.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.service
{
    public class BaseService
    {
        protected Basic_DbContext context;
        public BaseService(Basic_DbContext _context)
        {
            this.context = _context;
        }
    }
}
