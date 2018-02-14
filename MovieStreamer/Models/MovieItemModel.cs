﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieStreamer.Models
{
    public static class MovieConfiguration
    {
        public static string Path
        {
            get
            {
                return "/video/";
            }
        }
    }

    public class MovieEntity
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public string Type { get; set; }
        public string imdbRating { get; set; }
        [Key]
        public string imdbID { get; set; }
        public string Runtime { get; set; }
    }

    public class MovieViewModel
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public string Type { get; set; }
        public string imdbRating { get; set; }
        public string imdbID { get; set; }
        public bool AvailableToWatch { get; set; }
        public string MoviePath { get; set; }
        public string Runtime { get; set; }
    }

}