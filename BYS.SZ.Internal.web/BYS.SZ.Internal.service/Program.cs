using BYS.SZ.Internal.db.DBContext;
using BYS.SZ.Internal.db.DbOperation;
using BYS.SZ.Internal.db.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BYS.SZ.Internal.web.Service;
using System.Data;
using BYS.SZ.Internal.db.Entities;

namespace BYS.SZ.Internal.web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Basic_DbContext context = new Basic_DbContext();
            ManageService manageService = new ManageService(context);
            ExcelHelper helper = null;
            string testPath = "C:\\Users\\v-pengwu\\Downloads\\template.xlsx";
            try
            {
                helper = new ExcelHelper(testPath);
                DataTable dt = helper.ExcelToDataTable();
                var allLists = helper.TableToEntity(dt, typeof(BillingModel));
                if (dt != null)
                {
                    //Console.WriteLine(manageService.StoreExcel2Db(allLists));
                }
                else
                {
                    Console.WriteLine("Table为空！");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                helper.Dispose();
            }
            Console.ReadKey();
        }
    }
}
