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
    public partial class AddBulkStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submitbtn_Click(object sender, EventArgs e)
        {
            int rowsAdded = 0;
            ArrayList errors = earsBEEF.OLEDBManager.massStaffImport();
            if (errors.Count != 0)
            {
                for (int x = 0; x < errors.Count; x++)
                {
                    if(errors[x].ToString().Equals("Successfully Added!"))
                    {
                        rowsAdded++;
                    }
                    else{

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