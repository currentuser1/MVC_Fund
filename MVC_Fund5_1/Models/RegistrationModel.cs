using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Fund5_1.Models
{
    public class RegistrationModel
    {
        public string login { get; set; }
        public string password { get; set; }
        public string repeatpassword { get; set; }
        public string email { get; set; }
    }
}