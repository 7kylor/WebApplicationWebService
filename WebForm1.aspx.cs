using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationWebService;
 

namespace WebApplicationWebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Movie movieObj = new Movie();
            WebService1 webServiceObj = new WebService1();


         
           movieObj = webServiceObj.GetMovies(TextBox1.Text);

            Label5.Text = movieObj.MovieTitle;
           Label11.Text = Convert.ToString(movieObj.Release_Year);
            Label7.Text = Convert.ToString (movieObj.Average_Rating);
           Label8.Text =  Convert.ToString(movieObj.Duration) ;
            Label10.Text = movieObj.Director;






        }
    }
}