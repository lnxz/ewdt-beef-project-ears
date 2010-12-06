﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace earsBEEF
{
    public partial class RegisterEvent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //earsBEEF.Event e;
            //tbxName.Text = e.Name;
            //tbxVenue.Text = e.Venue;
            //tbxCategory.Text = EARS.DBManager.GetCategoryName(Convert.ToInt32(e.Category));
            //tbxDescription.Text = e.Descrip;
            //tbxEventDates.Text = e.EventDate;
            //tbxCCA.Text = EARS.DBManager.GetCCAName(e.CcaID);


        }

        protected void Page_PreInit()
        {
            this.MasterPageFile = Session["MyPage_Master"].ToString();
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            int eventID = 0;//edit as necessary
            EARS.Student s = (EARS.Student)(this.Session["Login"]);
            EARS.DBManager.AddStudentRegisterEvent(s.StudentID, eventID);
        }
    }
}