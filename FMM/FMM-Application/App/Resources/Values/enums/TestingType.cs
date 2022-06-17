using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class TestingType
{
    public static readonly string FIRST = " أولي ";
    public static readonly string SECONDARY = " ثانوي ";
    public static readonly string ULTIMATE = " نهائي";

    public List<string> getValues()
    {
        return new List<string>
        {
            FIRST,
            SECONDARY,
            ULTIMATE
        };
    }
}
}
