using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class State
{
    public static readonly string SOLID = " صلبة ";
    public static readonly string LIQUID = " سائلة ";
    public static readonly string INVASIVE = " غازية";

    public List<string> getValues()
    {
        return new List<string>
        {
            SOLID,
            LIQUID,
            INVASIVE
        };
    }
}
}
