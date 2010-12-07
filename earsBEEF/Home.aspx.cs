﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace earsBEEF
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_PreInit()
        {
            this.MasterPageFile = Session["MyPage_Master"].ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["LoginType"].Equals("Student"))
            {
                MultiView1.ActiveViewIndex = 0;

                gvStudentAnn.DataSource = EARS.DBManager.GetTop3Announcment();
                gvStudentAnn.DataBind();
                ArrayList studentCurrentEvent = new ArrayList();
                int counter = 0;

                foreach (EARS.Event a in EARS.DBManager.GetAllEvents())
                {
                    if (counter != 3)
                    {
                        if ((DateTime.Today >= a.RegistrationStart) && (DateTime.Today <= a.RegistrationEnd))
                        {
                            studentCurrentEvent.Add(a);
                            counter++;
                        }
                    }

                }
                gvStudentCurrentEvent.DataSource = studentCurrentEvent;
                gvStudentCurrentEvent.DataBind();
            }
            else if (Session["LoginType"].Equals(null))
            {
                Response.Redirect("loginPage.aspx");
            }
            else
            {
                MultiView1.ActiveViewIndex = 1;
            }
        }
    }
}