using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        {
            bindEvents();
            bindNews();
        }
    }
    public void bindNews() 
    {
        clsNews n = new clsNews();
        DataSet ds = n.ListNews();
        rptNews.DataSource = ds;
        rptNews.DataBind();
    }
    public void bindEvents() 
    {
        clsEvent ev = new clsEvent();
        DataSet ds = ev.listEvent();
        if (ds != null)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpEvent.DataSource = ds;
                rpEvent.DataBind();
            }
            else
            {
                rpEvent.Visible = false;
            }
        }
    }
}
  