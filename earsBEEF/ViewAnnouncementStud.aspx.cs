﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Data;
using System.Collections;

namespace earsBEEF
{
    public partial class ViewAnnouncementStud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //EARS.Staff s = (EARS.Staff)(Session["Login"]);
            //// for non-student leader and student not allow to access this page
            //if (s.IsStudentLeader.Equals('Y'))
            //{
            //    Response.Redirect("Home.aspx");
            //}
            //else if (s.IsStudentLeader.Equals('N'))
            //{
            //    Response.Redirect("Home.aspx");
            //}
            // end

            if (Page.IsPostBack)
            { }

            else
            {
                string a = DateTime.Today.ToShortDateString();
                string[] r = a.Split('/');
                DateTime dt = new DateTime(Convert.ToInt32(r[2]), Convert.ToInt32(r[0]) - 1, Convert.ToInt32(r[1]));


                ArrayList fk = new ArrayList();
                foreach (earsBEEF.Announcement x in EARS.DBManager.GetAllAnnouncements())
                {
                    if (x.DateOfAnn <= dt)
                    {

                    }
                    else
                    {
                        fk.Add(x);
                    }
                }
                GridView1.DataSource = fk;
                GridView1.DataBind();
            }
        }
        protected void Page_PreInit()
        {
            this.MasterPageFile = Session["MyPage_Master"].ToString();
        }

    }
}