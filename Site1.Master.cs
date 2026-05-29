using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DuongVanTrongDai_2906
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        xuly kn = new xuly();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q = "select * from LOAIDIENTHOAI";
            try
            {
                this.DataList1.DataSource = kn.GetData(q);
                this.DataList1.DataBind();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloaidienthoai = ((LinkButton)sender).CommandArgument;
            Context.Items["mldt"] = maloaidienthoai;
            Server.Transfer("product.aspx");
        }
    }
}
