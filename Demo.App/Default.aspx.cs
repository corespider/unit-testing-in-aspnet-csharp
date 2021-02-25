using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Demo.App.Models;
namespace Demo.App
{
    public partial class _Default : Page
    {
        Calculator _calc = new Calculator();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_add.Text ="Addition Value of (100,5) is : " + _calc.add(100, 5).ToString();
            labl_sub.Text = "Substraction Value of (100,5) is : " + _calc.sub(100, 5).ToString();
            lbl_mul.Text = "Multiplication Value of (100,5) is : " + _calc.mul(100, 5).ToString();
            lbl_div.Text = "Division Value of (100,5) is : " + _calc.div(100, 5).ToString();
        }
    }
}