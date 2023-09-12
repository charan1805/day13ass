using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Assignment10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblMsg.Visible = false;
            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Product Successfully Registered";
            LblMsg.Text += "<br>Product Name: " + PName.Text;
            LblMsg.Text += "<br>Product Category: " + PCategory.Text;
            LblMsg.Text += "<br>Product Price: " + PPrice.Text;
            LblMsg.Text += "<br>Product Description: " + PDescription.Text;
            LblMsg.Text += "<br>Product Release Date: " + PCalendar.SelectedDate;

        }
    }
}