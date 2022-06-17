using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class TargetGroup
{
    public static readonly string YOUNG = " صغار السن ";
    public static readonly string ELDER = " كبار السن ";

    public List<string> getValues()
    {
        return new List<string>
        {
            YOUNG,
            ELDER
        };
    }
}
}
