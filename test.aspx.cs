using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bindGrid();
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Test t = new Test();
        t.test = txtt1.Text;
        t.test1 = txtt2.Text;
        if (!string.IsNullOrEmpty(txtt1.Text) && !string.IsNullOrEmpty(txtt2.Text))
        {
            t.addval(t);
            bindGrid();
            pnlform.Visible = false;
            pnlData.Visible = true;
            txtt1.Text = "";
            txtt2.Text = "";
        }
    }

    protected void btnNewEntry_Click(object sender,EventArgs e) 
    {
        pnlData.Visible = false;
        pnlform.Visible = true;
    }

    public void bindGrid() 
    {
        Test t = new Test();
        DataSet ds = t.listval();
        List_Grid.DataSource = ds;
        List_Grid.DataBind();
    }
}