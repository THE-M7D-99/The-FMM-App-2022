using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class SterilizationType
{
    public static readonly string MANUAL = "  يدوي ";
    public static readonly string AUTO = " آلي ";

    public List<string> getValues()
    {
        return new List<string>
        {
            MANUAL,
            AUTO
        };
    }
}
}
