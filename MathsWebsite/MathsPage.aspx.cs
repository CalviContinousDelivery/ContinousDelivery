using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomLibrary;

namespace MathsWebsite
{
    public partial class MathsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            MathsLibrary obj = new MathsLibrary();
            int result = obj.Add(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text));
            txtResult.Text = result.ToString();
        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            MathsLibrary obj = new MathsLibrary();
            int result = obj.Subtract(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text));
            txtResult.Text = result.ToString();
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            MathsLibrary obj = new MathsLibrary();
            int result = obj.Multiply(Convert.ToInt32(txtNumber1.Text), Convert.ToInt32(txtNumber2.Text));
            txtResult.Text = result.ToString();
        }
    }
}