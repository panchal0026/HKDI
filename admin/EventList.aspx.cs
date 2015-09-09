using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;


public partial class admin_EventList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bindEvents();
        }

    }
    public void bindEvents()
    {
        clsEvent e = new clsEvent();
        DataSet ds = e.listEvent();
        gvEvent.DataSource = ds;
        gvEvent.DataBind();
    }

    protected void save_Click(object sender, EventArgs e)
    {
        saveEvent();
        pnldata.Visible = true;
        pnlform.Visible = false;
    }


    public void saveEvent()
    {
        try
        {

            clsEvent ev = new clsEvent();
            ev.Event_Title = txtEventTitle.Text;
            ev.Event_Description = txtEventDescription.Text;
            if (!string.IsNullOrEmpty(txtEventDate.Text))
                ev.Event_Date = Convert.ToDateTime(txtEventDate.Text);
            ev.Organized_by = txtOrganizedBy.Text;
            if (fu1.HasFile)
            {

                string filename = Path.GetFileName(fu1.PostedFile.FileName);
                string path = "../images/" + filename;
                fu1.SaveAs(Server.MapPath("~/images/") + filename);
                ev.Event_Image = path;
                // Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Image saved!')", true);
            }
            if (!string.IsNullOrEmpty(txtEventTitle.Text) && !string.IsNullOrEmpty(txtEventDescription.Text) && !string.IsNullOrEmpty(txtEventDate.Text) && !string.IsNullOrEmpty(txtOrganizedBy.Text))
            {
                ev.addEvent(ev);
                bindEvents();
                txtEventTitle.Text = "";
                txtEventDescription.Text = "";
                txtEventDate.Text = "";
                txtOrganizedBy.Text = "";
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void Event_Grid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("AddImage"))
        {
            int i = Convert.ToInt32(e.CommandArgument);
            hfImgID.Value = i.ToString();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "Func_PopUp()", true);
        }
    }

    protected void btnaddevent_Click(object sender, EventArgs e)
    {
        pnlform.Visible = true;
        pnldata.Visible = false;
    }

    protected void btnaddimage_Click(object sender, EventArgs e)
    {
        if (fileupload.HasFile)
        {

            string filename = Path.GetFileName(fileupload.PostedFile.FileName);
            string path = "../images/" + filename;
            fileupload.SaveAs(Server.MapPath("~/images/") + filename);

            clsEventImage eventImage = new clsEventImage();
            if (!string.IsNullOrEmpty(hfImgID.Value))
                eventImage.Event_ID = Convert.ToInt32(hfImgID.Value);
            eventImage.Event_Image = path;
            eventImage.IsActive = cb_IsActive.Checked;

            eventImage.Add_Event_Images(eventImage);
            // Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Image saved!')", true);
        }
    }
}