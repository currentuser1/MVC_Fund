using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Fund6_1.Models
{
    public class User
    {
        public string CodeCountry { get; set; }

        public CityCode CodeCity { get; set; }
        public string CodeUser { get; set; }

        
    }
    public enum CityCode
    {
        [Display(Name = "495")]
        one,
        [Display(Name = "615")]
        two,
        [Display(Name = "333")]
        three
    }
}