using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Hme : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bindNews();
    }
    public void bindNews()
    {
        clsNews n = new clsNews();
        DataSet ds = n.ListNews();
       
    }
    
}