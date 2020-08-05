using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab6
{
    public partial class RegisterCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // get method from helper
            List<Course> getAvailableCourses = Helper.GetAvailableCourses();
            if (this.IsPostBack == false)
            {
                //add the text and value
                for (int i = 0; i < getAvailableCourses.Count; i++)
            {
                courseList1.Items.Add(new ListItem(getAvailableCourses[i].Title+" - "+getAvailableCourses[i].WeeklyHours+" hours/week", getAvailableCourses[i].Code));
                }
            }
            fulltimeAlert.Visible = false;
            pnlAlert.Visible = false;
            parttimeAlert.Visible = false;
            coopAlert1.Visible = false;
            coopAlert2.Visible = false;
            table2.Visible = false;        
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            // declare variable to 0, use it in the foreach loop to to get the final resule then compare
            int totalHours = 0;
            int totalcount = 0;         
            foreach (ListItem item in courseList1.Items)
            {
                if (item.Selected == true)
                {
                    totalcount++;
                    //create table content row and coloum
                    TableRow row = new TableRow();
                    TableCell cell2 = new TableCell();
                    TableCell cell3 = new TableCell();
                    TableCell cell1 = new TableCell();
                    List<Course> getAvailableCourses = Helper.GetAvailableCourses();
                    int j = courseList1.Items.IndexOf(item);
                    totalHours += getAvailableCourses[j].WeeklyHours;
                    cell3.Text = getAvailableCourses[j].WeeklyHours.ToString();
                    cell2.Text = getAvailableCourses[j].Title;
                    cell1.Text = item.Value;
                    row.Cells.Add(cell1);
                    row.Cells.Add(cell2);
                    row.Cells.Add(cell3);
                    table2.Rows.Add(row);   
                }  
            }
            // the last row
            TableRow lastrow = new TableRow();
            TableCell cell4 = new TableCell();
            TableCell cell5 = new TableCell();
            TableCell cell6 = new TableCell();
            cell4.Text = " ";
            cell5.Text = "Total";
            //align the txt at the right side
            cell5.HorizontalAlign = HorizontalAlign.Right;
            cell6.Text = totalHours.ToString();
            lastrow.Cells.Add(cell4);
            lastrow.Cells.Add(cell5);
            lastrow.Cells.Add(cell6);
            table2.Rows.Add(lastrow);
            // compare the hours and course counts with full/part/coop
            if (full.Selected && totalHours > 16)
            {
                fulltimeAlert.Visible = true;
            }
            if (TextBox1.Text !="" && full.Selected && totalHours <= 16)
            {
                fulltimeAlert.Visible = false;
                txtchange.Text = "has successfully enrolled in the following courses: ";
                TextBox1.ReadOnly = true;
                courseList1.Visible = false;
                Button.Visible = false;
                table2.Visible = true;
            }
            if (part.Selected && totalcount > 3)
            {
                parttimeAlert.Visible = true;
            }
            if (TextBox1.Text != "" && part.Selected && totalcount <= 3)
            {
                fulltimeAlert.Visible = false;
                txtchange.Text = "has successfully enrolled in the following courses: ";
                TextBox1.ReadOnly = true;
                courseList1.Visible = false;
                table2.Visible = true;
                Button.Visible = false;
            }
            if (coop.Selected && totalcount > 2)
            {
                coopAlert1.Visible = true;
            }
            if (coop.Selected && totalHours > 4)
            {
                coopAlert2.Visible = true;
            }
            if (TextBox1.Text != "" && coop.Selected && totalcount <= 2 && totalHours <= 4)
            {
                fulltimeAlert.Visible = false;
                txtchange.Text = "has successfully enrolled in the following courses: ";
                TextBox1.ReadOnly = true;
                courseList1.Visible = false;
                table2.Visible = true;
                Button.Visible = false;
            }
            //if the textbox pnl is visible
            if (TextBox1.Text == "")
            {
                pnlAlert.Visible = true;
            }
            else
            {
                pnlAlert.Visible = false;
            }

            
        }
    }
}