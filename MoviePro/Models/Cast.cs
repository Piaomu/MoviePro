﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Cast
    {
        public int Id {get; set;}
        
        public int MovieId { get; set; }
        
        //TMDB castID used to identify cast across movies
        public int CastId { get; set; }

        public string Department { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }

        //(This is Order of importance for casting)
        public int Order { get; set; }

        //Profile Image
        [Display(Name="Profile Pic")]
        public byte[] Profile { get; set; }
        public string ContentType { get; set; }
    }
}
