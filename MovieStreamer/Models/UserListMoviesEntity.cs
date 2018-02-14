﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieStreamer.Models
{
    public class UserListMoviesEntity
    {
        public string UserId { get; set; }
        public string imdbID { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}