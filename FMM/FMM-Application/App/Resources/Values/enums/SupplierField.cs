using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class SupplierField
{
    public static readonly string ROW_MATERIALS = " مواد أولية ";
    public static readonly string REQUIREMENTS = " متطلبات ";
    public static readonly string PURCHASES = " مشتريات";
    public static readonly string SEPERATE_PIECE = " قطعة منفصلة";

    public List<string> getValues()
    {
        return new List<string>
        {
            ROW_MATERIALS,
            REQUIREMENTS,
            PURCHASES,
            SEPERATE_PIECE
        };
    }
}
}
