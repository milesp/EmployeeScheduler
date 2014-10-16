using ES.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeScheduler
{
     public partial class _default : System.Web.UI.Page
     {
          protected void Page_Load(object sender, EventArgs e)
          {

          }

          protected void Button1_Click(object sender, EventArgs e)
          {
               int numOfShiftsPerDay = Convert.ToInt32(shiftsPerDay.Text.ToString());
               int workDaysPerWeek = Convert.ToInt32(numOfDays.Text.ToString());
               //Label2.Text = shiftsPerDay.Text;
               string x = shiftsPerDay.Text.ToString();
               bool[,] availability = new bool[workDaysPerWeek, numOfShiftsPerDay];
               //Label2.Text = x;
               Employee q = new Employee();
               //name, ssn, exp, availability, wage, min, max
               Employee y = new Employee("miles", "124432", 1.0, availability, 20.0, 1, 1);

          }

          protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
          {
               Shift temp = new Shift();
          }
     }
}