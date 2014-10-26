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
         
          protected void Page_Load(object sender, EventArgs e)
          {
               if (Page.IsPostBack == false)
               {

                    Repeater1.Visible = false;
               }
          }
          

          protected void Button1_Click(object sender, EventArgs e)
          {
               
               int dayss = Convert.ToInt32(shiftsPerDay.Text.ToString());
               int shiftsss = Convert.ToInt32(numOfDays.Text.ToString());
               WorkPeriod myWorkPeriod = (new WorkPeriod(dayss, shiftsss));               
               Repeater1.DataSource = new[] { myWorkPeriod.workWeek[0, 0] }.ToList();
               Repeater1.DataBind();
               Repeater1.Visible = true;
          }
     }
}