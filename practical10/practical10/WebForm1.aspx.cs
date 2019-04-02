using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        WebService1 calc = new WebService1();
        protected void btnp_Click(object sender, EventArgs e)
        {
            lblre.Text = calc.add(Convert.ToInt16(txba.Text), Convert.ToInt16(txbb.Text)).ToString();
        }

        protected void btnm_Click(object sender, EventArgs e)
        {
             lblre.Text = calc.sub(Convert.ToInt16(txba.Text), Convert.ToInt16(txbb.Text)).ToString();
        }

        protected void btnd_Click(object sender, EventArgs e)
        {
            lblre.Text = calc.div(Convert.ToInt16(txba.Text), Convert.ToInt16(txbb.Text)).ToString();
        }

        protected void btnmul_Click(object sender, EventArgs e)
        {
            lblre.Text = calc.mul(Convert.ToInt16(txba.Text), Convert.ToInt16(txbb.Text)).ToString();
        }
    }
}