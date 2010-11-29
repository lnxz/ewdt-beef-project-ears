﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;



namespace EARS
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mv.ActiveViewIndex = 0;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string id = tbxId.Text;
            string email = tbxEmail.Text;

            if (Session["LoginType"].Equals("Student"))
            {
                // check student
                EARS.Student s = DBManager.ValidatePasswordStud(id, email);

                if (s != null)
                {
                    // generate password
                    string pass = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    string p = "";
                    Random r = new Random();
                    for (int i = 0; i < 8; i++)
                    {
                        p = p + pass.Substring(r.Next(0, pass.Length - 1), 1);
                    }

                    string password = p;

                    EARS.Student stu = DBManager.UpdatePasswordStud(id, p);

                    // create a email object
                    MailMessage mail = new System.Net.Mail.MailMessage();
                    // set the log in authentication for the email so that can send email to others
                    // login and password for email.
                    NetworkCredential cred = new System.Net.NetworkCredential("earsbeef@gmail.com", "earsbeef");

                    mail.To.Add(email); // add the receipt email
                    mail.Subject = "Password for EARs System"; // add email subject
                    mail.From = new System.Net.Mail.MailAddress("earsbeef@gmail.com"); // sender
                    mail.IsBodyHtml = true; // if there is a hyperlink set to true
                    mail.Body = "Here is your email password for your account :" + p;

                    //gateway for email to be send
                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = cred;
                    smtp.Port = 587;
                    smtp.Send(mail);

                    //MailMessage mail1 = new MailMessage("earsbeef@gmail.com",email,"Reset Password","Here is your new password");
                    //SmtpClient client = new SmtpClient("earsbeef@gmail.com",25);
                    //client.UseDefaultCredentials = true;
                    //client.Send(mail);
                    ////http://www.c-sharpcorner.com/uploadfile/scottlysle/emailattachmentscs08052008234321pm/emailattachmentscs.aspx
                    mv.ActiveViewIndex = 1;

                }
                else
                {
                    Label5.Text = "Login ID and Email Unmatch";
                }
            }
            else if (Session["LoginType"].Equals("Staff"))
            {

                // check staff
                EARS.Staff t = DBManager.ValidatePasswordStaff(tbxId.Text, tbxEmail.Text);

                if (t != null)
                {
                    // generate Password
                    string passString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    string value = "";
                    Random ra = new Random();
                    for (int i = 0; i < 8; i++)
                    {
                        value = value + passString.Substring(ra.Next(0, value.Length - 1), 1);
                    }

                    string password1 = value;
                    // create a email object
                    MailMessage mail = new System.Net.Mail.MailMessage();
                    // set the log in authentication for the email so that can send email to others
                    // login and password for email.
                    NetworkCredential cred = new System.Net.NetworkCredential("earsbeef@gmail.com", "earsbeef");

                    mail.To.Add(email); // add the receipt email
                    mail.Subject = "Password for EARs System"; // add email subject
                    mail.From = new System.Net.Mail.MailAddress("earsbeef@gmail.com"); // sender
                    mail.IsBodyHtml = true; // if there is a hyperlink set to true
                    mail.Body = "Here is your email password for your account :" + value;

                    //gateway for email to be send
                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                    smtp.UseDefaultCredentials = false;
                    smtp.EnableSsl = true;
                    smtp.Credentials = cred;
                    smtp.Port = 587;
                    smtp.Send(mail);

                    mv.ActiveViewIndex = 1;
                }
                else
                {
                    Label5.Text = "Login ID and Email Unmatch";
                }
            }
        }

        protected void btnSubmit1_Click(object sender, EventArgs e)
        {
            string pe = tbxPEmail.Text;
            string id1 = tbxId.Text;
            // check student

            if (Session["LoginType"].Equals("Student"))
            {
                EARS.Student s = DBManager.GetPasswordStud(id1, pe);

                if (s != null)
                {
                    mv.ActiveViewIndex = 2;
                }
                else
                {
                    Label6.Text = "Invalid Email Password, Please Confirm the Password";
                }
            }
            else if (Session["LoginType"].Equals("Staff"))
            {
                    // check staff
                    EARS.Staff sta = DBManager.GetPasswordStaff(id1, pe);

                    if (sta != null)
                    {
                        mv.ActiveViewIndex = 2;
                    }
                    else
                    {
                        Label6.Text = "Invalid Email Password, Please Confirm the Password";
                }
            }

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string p = tbxPwC2.Text;
            string id2 = tbxId.Text;

            // change student password
            EARS.Student stu = DBManager.GetPasswordStud(id2,p);

            if (Session["LoginType"].Equals("Student"))
            {
                if (stu != null)
                {
                    EARS.Student stu1 = DBManager.UpdatePasswordStud(id2, p);
                }
                else
                {
                    Label7.Text = "Error";
                }
            }
            else if (Session["LoginType"].Equals("Staff"))
            {

                // change staff password
                EARS.Staff staff = DBManager.GetPasswordStaff(id2, p);

                if (staff != null)
                {
                    EARS.Staff sta1 = DBManager.ValidatePasswordStaff(id2, p);
                }
                else
                {
                    Label7.Text = "Error";
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}