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
          private int numOfShiftsPerDay;
          private int workDaysPerWeek;
          private Shift[,] workWeek;
          protected void Page_Load(object sender, EventArgs e)
          {

          }

          protected void Button1_Click(object sender, EventArgs e)
          {
               numOfShiftsPerDay = Convert.ToInt32(shiftsPerDay.Text.ToString());
               workDaysPerWeek = Convert.ToInt32(numOfDays.Text.ToString());
               //Label2.Text = shiftsPerDay.Text;
               string x = shiftsPerDay.Text.ToString();
               bool[,] availability = new bool[workDaysPerWeek, numOfShiftsPerDay];
               Shift[,] shiftArray = new Shift[workDaysPerWeek, numOfShiftsPerDay];
               for (int i = 0; i < workDaysPerWeek; i++)
               {
                    for (int j = 0; j < numOfShiftsPerDay; j++)
                    {
                         Shift blankShift = new Shift();
                         shiftArray[i, j] = blankShift;
                    }
               }
               workWeek = shiftArray;
               //Label2.Text = x;
               Employee q = new Employee();
               //name, ssn, exp, availability, wage, min, max
               Employee y = new Employee("miles", "124432", 1.0, availability, 20.0, 1, 1);


          }

          public static System.Collections.ICollection GetShifts()
          {
               return new[] { new Shift(), new Shift() }.ToList();
          }
     }
}