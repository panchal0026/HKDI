using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_NewsList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bindNews();
        }

    }
    public void btnSubmitNews_Click(object sender, EventArgs e)
    {

        clsNews n = new clsNews();
        n.News_Title = txtNews_Title.Text;
        n.News_Description = txtNews_Description.Text;
        if (!string.IsNullOrEmpty(txtNews_Date.Text))
            n.News_Date = Convert.ToDateTime(txtNews_Date.Text);
        if (!String.IsNullOrEmpty(txtNews_Title.Text) && !String.IsNullOrEmpty(txtNews_Description.Text) && !String.IsNullOrEmpty(txtNews_Date.Text))
        {
            n.AddNews(n);
            bindNews();
            pnlgridNews.Visible = true;
            pnlformNews.Visible = false;

        }
        txtNews_Title.Text = "";
        txtNews_Description.Text = "";


    }

    public void clear()
    {
        txtNews_Title.Text = "";
        txtNews_Description.Text = "";
        txtNews_Date.Text = "";
    }
    public void bindNews()
    {
        clsNews n = new clsNews();
        DataSet ds = n.ListNews();
        gvNews.DataSource = ds;
        gvNews.DataBind();
    }

    public void btnAddNews_Click(object sender, EventArgs e)
    {
        pnlgridNews.Visible = false;
        pnlformNews.Visible = true;

    }
    public void buttoncancel_click(object sender, EventArgs e)
    {
        pnlgridNews.Visible = true;
        pnlformNews.Visible = false;
        clear();
    }
}