using AutoMapper;
using BYS.SZ.Internal.db.Entities;
using BYS.SZ.Internal.db.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYS.SZ.Internal.db.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<BillingProfile>();
            });
        }
        
        public class BillingProfile : Profile
        {
            public BillingProfile()
            {
                
            }
        }
    }
}
