using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class ProcessType
{
    public static readonly string DEPOSIT_TO_THE_ACCOUNT = " الإيداع في الحساب ";
    public static readonly string ACCOUNT_DEDUCTION = " خصم الحساب ";

    public List<string> getValues()
    {
        return new List<string>
        {
            DEPOSIT_TO_THE_ACCOUNT,
            ACCOUNT_DEDUCTION
        };
    }
}
}
