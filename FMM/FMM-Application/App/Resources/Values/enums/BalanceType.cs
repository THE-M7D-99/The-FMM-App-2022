using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class BalanceType
{
    public static readonly string FIRST_BALANCES = " الأرصدة الأولى ";
    public static readonly string MOVEMENT_DURING_A_LIMITED_PREIOD = " حركة خلال فترة محدودة ";

    public List<string> getValues()
    {
        return new List<string>
        {
            FIRST_BALANCES,
            MOVEMENT_DURING_A_LIMITED_PREIOD
        };
    }
}
}
