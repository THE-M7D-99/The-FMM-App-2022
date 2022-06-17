using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class EndebtednessType
{
    public static readonly string CREDITOR = " دائن ";
    public static readonly string DEBTOR = " مدين ";

    public List<string> getValues()
    {
        return new List<string>
        {
            CREDITOR,
            DEBTOR
        };
    }
}
}
