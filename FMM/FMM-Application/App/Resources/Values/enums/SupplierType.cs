using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class SupplierType
{
    public static readonly string INTERNAL = " داخلي ";
    public static readonly string EXTERNAL = " خارجي ";

    public List<string> getValues()
    {
        return new List<string>
        {
            INTERNAL,
            EXTERNAL
        };
    }
}
}
