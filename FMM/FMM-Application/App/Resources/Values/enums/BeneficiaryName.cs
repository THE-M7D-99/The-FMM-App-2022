using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class BeneficiaryName
{
    public static readonly string ACCOUNT_NAME = " اسم الحساب ";
    public static readonly string NAME_OF_NOT_HAVING_BANK_ACCOUNT = " اسم من لا يمتلك حساب بنك ";

    public List<string> getValues()
    {
        return new List<string>
        {
            ACCOUNT_NAME,
            NAME_OF_NOT_HAVING_BANK_ACCOUNT
        };
    }
}
}
