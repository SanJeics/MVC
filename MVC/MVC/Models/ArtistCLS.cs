using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class ArtistCLS
    {
        [Display(Name = "Artista")]
        public string Name { get; set; }
    }
}