using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Program
    {
        public enum CityCode
        {
            [Display(Name = "495")]
            One,
            [Display(Name = "812")]
            Two,
            [Display(Name = "601")]
            Three
        }
        static void Main(string[] args)
        {
            foreach(var value in Enum.GetNames(typeof(CityCode)))
            {
                Console.WriteLine(value);
            }
   

        }

    }
}
