using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ES.Model;


namespace EmployeeScheduler
{
     public partial class _Default : Page
     {
          protected void Page_Load(object sender, EventArgs e)
          {


          }

          public void NumOfDays_TextChanged(object sender, EventArgs e)
          {
              /* int workDaysPerWeek = Convert.ToInt32(shiftsPerDay.Text.ToString());
               int numOfShiftsPerDay = Convert.ToInt32(numOfDays.Text.ToString());
               //Label2.Text = shiftsPerDay.Text;
               string x = shiftsPerDay.Text.ToString();
               bool[,] availability = new bool[workDaysPerWeek, numOfShiftsPerDay];
               //Label2.Text = x;
               Employee q = new Employee();
               //name, ssn, exp, availability, wage, min, max
               Employee y = new Employee("miles", "124432", 1.0, availability, 20.0, 1, 1);*/

          }

     }
}