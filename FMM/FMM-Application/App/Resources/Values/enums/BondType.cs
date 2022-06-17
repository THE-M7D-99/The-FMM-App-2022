using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class BondType
{
    public static readonly string A = " عيني ";
    public static readonly string CASH = " نقدي ";

    public List<string> getValues()
    {
        return new List<string>
        {
            A,
            CASH
        };
    }
}
}
