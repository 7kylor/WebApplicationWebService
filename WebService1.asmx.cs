using System; 
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    //
    
    public class Movie {
            public String Director, Genre, MovieTitle;
            public DateTime Release_Year;
            public TimeSpan Duration;
            public Double Average_Rating;
        }
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public Movie GetMovies(String MovieTitle) { 
            

            Movie movieOBJ = new Movie();


            if (MovieTitle == "Avengers End Game")
            {
                movieOBJ.Average_Rating = 5;
                movieOBJ.MovieTitle = MovieTitle;
                movieOBJ.Director = "test";
                movieOBJ.Release_Year = DateTime.Now;
                movieOBJ.Duration = TimeSpan.FromHours(2.3);
                movieOBJ.Director = "whatever";
                movieOBJ.Genre = "SiFi Baby";
                
            }
            else if (MovieTitle == "Batman VS Superman")
            {
                movieOBJ.Average_Rating = 04;
                movieOBJ.MovieTitle = MovieTitle;
                movieOBJ.Director = "test";
                movieOBJ.Release_Year = DateTime.Now;
                movieOBJ.Duration = TimeSpan.FromHours(2.3);
                movieOBJ.Director = "whatever";
                movieOBJ.Genre = "SiFi Baby";
            } 


            return movieOBJ;
        }
    }
}
