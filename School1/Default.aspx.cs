using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace School1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCombine_Click(object sender, EventArgs e)
        {
            ////this.lblResult.Text = this.txtFirstName.Text + " " + this.txtGender.Text;
            //if (this.txtGender.Text.ToUpper() == "MALE")
            //{
            //    this.lblResult.Text = "Hello, Sir " + this.txtFirstName.Text + "." ;
            //}
            //else
            //{
            //    this.lblResult.Text = "Hello, Ma'am " + this.txtFirstName.Text + ".";
            //}

            try
            {
                switch (this.txtGender.Text.ToUpper())
                {
                    case "MALE":
                        this.lblResult.Text = "Hello, Sir " + this.txtFirstName.Text + ".";
                        break;

                    case "FEMALE":
                        this.lblResult.Text = "Hello, Ma'am " + this.txtFirstName.Text + "."; 
                        break;

                    default:
                        this.lblResult.Text = this.txtFirstName.Text + ", please specify your gender.";
                        break;
                }
            }
            catch(Exception ex)
            {
                this.lblResult.Text = ex.Message;
            }
            
        }
    }
}