﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace EARS
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Boolean loginSuccess = false;
            foreach (Student s in DBManager.GetAllStudents())
            {
                if (tbxLoginId.Text.Equals(s.AdminNo) && tbxLoginPw.Text.Equals(s.Password))
                {
                    loginSuccess = true;
                    FormsAuthentication.SetAuthCookie(s.Name, false);
                    Session["loginUserName"] = tbxLoginId.Text;
                    if(FormsAuthentication.GetRedirectUrl(s.Name,false) == "/LoginPage.aspx")
                    {   Response.Redirect("TESTPAGE.aspx");
                    }
                    else{
                        FormsAuthentication.RedirectFromLoginPage(s.Name, false);
                    }
                }
            }

            foreach (Staff st in DBManager.GetAllStaff())
            {
                if (tbxLoginId.Text.Equals(st.StaffEmail) && tbxLoginPw.Text.Equals(st.Password))
                {
                    loginSuccess = true;
                    FormsAuthentication.SetAuthCookie(st.Name, false);
                }
            }

        }
    }
}