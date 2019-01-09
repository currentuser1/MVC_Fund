using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Reflection;

namespace MVC_Fund6_1.Models
{
    public class User
    {
        public string CodeCountry { get; set; }
        public string CodeUser { get; set; }
        public CityCode CodeCity { get; set; }
    }
    public enum CityCode
    {
        [Description("495")]
        One,
        [Description("351")]
        Two,
        [Description("812")]
        Three
    }

}