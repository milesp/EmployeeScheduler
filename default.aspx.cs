using ES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Caching;

namespace EmployeeScheduler
{
     public partial class _default : System.Web.UI.Page
     {
         public WorkPeriod myWorkPeriod { get; set; }
          protected void Page_Load(object sender, EventArgs e)
          {
               if (myWorkPeriod == null)
               {
                    CacheItemPolicy policy = new CacheItemPolicy();
                    myWorkPeriod = new WorkPeriod();
                    ObjectCache cache = MemoryCache.Default;
                    string workLabel = cache["workLabel"] as string;
                    cache.Set("workLabel", myWorkPeriod, policy);
               }

          }
          

          protected void Button1_Click(object sender, EventArgs e)
          {
               
               //Label2.Text = x;
               //Employee q = new Employee();
               //name, ssn, exp, availability, wage, min, max
               //Employee y = new Employee("miles", "124432", 1.0, availability, 20.0, 1, 1);
               //int dayss = Convert.ToInt32(shiftsPerDay.Text.ToString());
               //int shiftsss = Convert.ToInt32(numOfDays.Text.ToString());
               int dayss = Convert.ToInt32(shiftsPerDay.Text.ToString());
               int shiftsss = Convert.ToInt32(numOfDays.Text.ToString());
               myWorkPeriod = (new WorkPeriod(dayss, shiftsss));              
               
          }

          public static System.Collections.ICollection GetShifts()
          {
               //move this to default???
               return new[] { new Shift(), new Shift() }.ToList();
          }

          protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
          {

          }


     }
}