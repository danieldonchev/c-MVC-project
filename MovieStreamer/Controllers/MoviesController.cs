using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MovieStreamer.Models;

namespace MovieStreamer.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public async Task<ActionResult> Movies(string id)
        {
            MovieDB db = new MovieDB();
            MovieViewModel MovieItem = new MovieViewModel();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com/");
                
                HttpResponseMessage response = await client.GetAsync(string.Format("?i={0}", id));
                 if (response.IsSuccessStatusCode)
                 {
                     MovieItem = await response.Content.ReadAsAsync<MovieViewModel>();
                }
            }
            if (db.ListMovies.Find(id, this.CurrentUserId()) != null)
            {
                MovieItem.AvailableToWatch = true;
            }
            return View(MovieItem);
        }

        public ActionResult PlayMovie(string id)
        {
            MovieDB db = new MovieDB();
            MovieViewModel MovieItem = new MovieViewModel();

            if (db.ListMovies.Find(id, this.CurrentUserId()) != null)
            {
                MovieItem.AvailableToWatch = true;
                MovieItem.MoviePath = MovieConfiguration.Path + id;
            }
            return View(MovieItem);
        }

        public string CurrentUserId()
        {
            return User.Identity.GetUserId();
        }
    }
}