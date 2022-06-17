using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class InvoiceType
{
    public static readonly string PURCHASES = " مشتريات ";
    public static readonly string SALES = " مبيعات ";

    public List<string> getValues()
    {
        return new List<string>
        {
            PURCHASES,
            SALES
        };
    }
}
}
