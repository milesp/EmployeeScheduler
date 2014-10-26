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
          
          /*method on click of the button to get the 2 inputs, and instatiate
           * the instance of workPeriod.  This instance will initially create
           * days * shifts number of shifts into a 2d array of shifts.  These
           * shifts will then be bound to a repeater and posted to screen per corresponding
           * shift.
           * 
           * */
          protected void Button1_Click(object sender, EventArgs e)
          {
               
               int days = Convert.ToInt32(shiftsPerDay.Text.ToString());
               int shifts = Convert.ToInt32(numOfDays.Text.ToString());
               WorkPeriod myWorkPeriod = (new WorkPeriod(days, shifts));               
               Repeater1.DataSource = new[] { myWorkPeriod.workWeek[0].shiftsInDay[0] }.ToList();
               Repeater1.DataBind();
               Repeater1.Visible = true;
          }
     }
}