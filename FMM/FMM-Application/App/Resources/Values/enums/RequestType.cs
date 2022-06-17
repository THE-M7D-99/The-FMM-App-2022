using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class RequestType
{
    public static readonly string DETALED = " مفصل ";
    public static readonly string OVEALL = " إجمالي ";

    public List<string> getValues()
    {
        return new List<string>
        {
            DETALED,
            OVEALL
        };
    }
}
}
