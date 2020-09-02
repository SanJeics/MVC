using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVC.Models
{
    public class GenreCLS
    {
        [Display(Name = "Genero musical")]
        public string Name { get; set; }
    }
}