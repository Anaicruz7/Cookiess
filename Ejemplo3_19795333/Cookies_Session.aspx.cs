using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejemplo3_19795333
{
	public partial class Cookies_Session : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            ddlCategory.SelectedValue = Session["ddlCategory"].ToString();
            ddlSupplier.SelectedValue = Session["ddlSupplier"].ToString();
            txtProduct.Text = Session["txtProduct"].ToString();
            txtDescripcion.Text = Session["txtDescripcion"].ToString();
            txtImagen.Text = Session["txtImagen"].ToString();


            Decimal decPrice = Convert.ToDecimal(Session["txtPrice"]);
            txtPrice.Text = decPrice.ToString("C");

            txtNumberInStock.Text = Session["txtNumberInStock"].ToString();
            txtNumberOnOrder.Text = Session["txtNumberOnOrder"].ToString();
            txtReorderLevel.Text = Session["txtReorderLevel"].ToString();



            Byte byNumberInStock = Convert.ToByte(Session["txtNumberInStock"]);
            Byte byNumberOnOrder = Convert.ToByte(Session["txtNumberOnOrder"]);



            Decimal decValueInStock = decPrice * byNumberInStock;
            Decimal decValueOnOrder = decPrice * byNumberOnOrder;
            txtValueInStock.Text = decValueInStock.ToString("c");
            txtValueOnOrder.Text = decValueOnOrder.ToString("c");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}