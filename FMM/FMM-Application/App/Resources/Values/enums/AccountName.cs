using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class AccountName
{
    public static readonly string DEPT_ACCOUNT = " حساب الديون ";
    public static readonly string CREDITOR_ACCOUNT = " حساب الدائن ";

    public List<string> getValues()
    {
        return new List<string>
        {
            DEPT_ACCOUNT,
            CREDITOR_ACCOUNT
        };
    }
}
}
