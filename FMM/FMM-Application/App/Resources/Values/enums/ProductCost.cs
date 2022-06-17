using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class ProductCost
{
    public static readonly string HIGH = " عالية ";
    public static readonly string MEDUIM = " متوسطة ";
    public static readonly string LOW = " منخفضة";

    public List<string> getValues()
    {
        return new List<string>
        {
            HIGH,
            MEDUIM,
            LOW
        };
    }
}
}
