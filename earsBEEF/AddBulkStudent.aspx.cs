﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Collections;

namespace earsBEEF.Admin_Forms
{
    public partial class AddBulkStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // non student leaders cannot access it
            if (Session["LoginType"].Equals("Student"))
            {
                EARS.Student s = (EARS.Student)(Session["Login"]);
                if (s.IsStudentLeader.Equals('Y'))
                {
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
            }


            // non staff admin are not allow to access
            if (Session["LoginType"].Equals("Staff"))
            {
                EARS.Staff sta = (EARS.Staff)(Session["Login"]);
                if (sta.Admin.Equals('Y'))
                {
                }
                else
                {
                    Response.Redirect("Home.aspx");
                }
                // end
            }
        }

        protected void Page_PreInit()
        {
            this.MasterPageFile = Session["MyPage_Master"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            if (FileUpload1.PostedFile.ContentLength == 0)
            {
                Label1.Text = "Cannot upload file with 0 length";
            }
            else
            {
                Label1.Text = FileUpload1.PostedFile.FileName;
                filePath = @"C:\Temp\" + Label1.Text;
                FileUpload1.PostedFile.SaveAs(filePath);
            }

           int rowsAdded = 0;
            ArrayList errors = earsBEEF.OLEDBManager.massStudentImport(filePath);
            if (errors.Count != 0)
            {
                for (int x = 0; x < errors.Count; x++)
                {
                    if (errors[x].ToString().Equals("Successfully Added!"))
                    {
                        rowsAdded++;
                    }
                    else
                    {

                        TextBox1.Text = TextBox1.Text + errors[x].ToString() + "\n";
                    }
                }
                if (rowsAdded > 0)
                {
                    TextBox1.Text = TextBox1.Text + rowsAdded + " rows successfully added" + "\n";
                }
            }
        }
    }
}