using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webass
{
    public partial class data : System.Web.UI.Page
    {
        WebService1 calc = new WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

       

        protected void adddata(object sender, EventArgs e)
        {
            ans.Text = calc.add(Convert.ToInt16(no1.Text), Convert.ToInt16(no2.Text)).ToString();
        }

        

       
    }
}