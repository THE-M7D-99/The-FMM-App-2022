using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class Currency
{
    public static readonly string YEMENI_RIYAL = "ريال يمني ";
    public static readonly string SAUDI_RIYAL = " ريال سعودي ";
    public static readonly string DOLLAR = " دولار";

    public List<string> getValues()
    {
        return new List<string>
        {
            YEMENI_RIYAL,
            SAUDI_RIYAL,
            DOLLAR
        };
    }
}
}
