using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static String GetNameFromDescription(Enum enumElement)
        {
            Type type = enumElement.GetType();
            MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                Object[] attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes != null && attributes.Length > 0)
                    return ((DescriptionAttribute)attributes[0]).Description;
            }
            return enumElement.ToString();
        }

        static void Main(string[] args)
        {

            Console.WriteLine(GetNameFromDescription(CityCode.One));
        }
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
