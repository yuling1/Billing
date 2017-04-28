using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BYS.SZ.Internal.db.Entities;
using BYS.SZ.Internal.web;
using BYS.SZ.Internal.db.DBContext;
using BYS.SZ.Internal.service;
using BYS.SZ.Internal.web.Service;
using System.Data;
using BYS.SZ.Internal.db.Model;

namespace BYS.SZ.Internal.db.DbOperation
{
    public class ManageService : BaseService
    {
        const string nameSpace = "BYS.SZ.Internal.db.Entities";
        public ManageService(Basic_DbContext context) : base(context)
        {
        }

        public string StoreExcel2Db(List<List<object>> allLists)
        {
            try
            {
                foreach (var lists in allLists)
                {
                    foreach (var property in context.GetType().GetProperties())
                    {
                        if (property.PropertyType.IsGenericType && property.PropertyType.GenericTypeArguments[0] == lists[0].GetType())
                        {
                            var propertyValue = property.GetGetMethod().Invoke(context, new object[0]);
                            lists.ForEach(x => property.PropertyType.GetMethod("Add").Invoke(propertyValue, new[] { x }));
                        }

                    }
                }
                context.SaveChanges();
                return "Success";
            }catch(Exception e)
            {                
                return "Error: " + e.ToString();
            }          
        }

        /// <summary>
        /// To solve the Foreign Key issue, this method will give a guid of the related context entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public bool ConvertModel2Context(List<BillingModel> billingLists, Basic_DbContext context)
        {
            List<Type> types = typeof(db.DBContext.Basic_DbContext).Assembly.GetTypes().Where(x => x.Namespace.Contains(nameSpace)).ToList();//获取名为space的NameSpace下的所有Type
            foreach(Type type in types)
            {
                
            }
            foreach (var billing in billingLists)
            {
                
            }
            return true;
        }
    }
}
