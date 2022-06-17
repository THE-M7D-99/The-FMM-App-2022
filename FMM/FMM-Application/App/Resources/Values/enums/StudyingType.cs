using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class StudyingType
{
    public static readonly string PRIMITIVE = " بدائية ";
    public static readonly string FINAL = " نهائية ";

    public List<string> getValues()
    {
        return new List<string>
        {
            PRIMITIVE,
            FINAL
        };
    }
}
}
