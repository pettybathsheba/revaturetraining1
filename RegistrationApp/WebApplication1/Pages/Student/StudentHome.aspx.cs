using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Pages.Student
{
    public partial class StudentHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //ShowSchedule();
        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }

        //private void ShowSchedule
        //{
        //    var data = new EntityDataSource


        //    foreach (var item in data.GetGenders())
        //    {
        //        genderlist.Items.Add(item.Name);
        //    }





    }
}