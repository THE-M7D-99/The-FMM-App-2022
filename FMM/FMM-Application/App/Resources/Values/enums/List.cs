using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class List
{
    public static readonly string INCOME_LIST = " قائمة الدخل ";
    public static readonly string STATEMENT_OF_FINANCIAL_POSITION = " قائمة المركز المالي ";

    public List<string> getValues()
    {
        return new List<string>
        {
            INCOME_LIST,
            STATEMENT_OF_FINANCIAL_POSITION
        };
    }
}
}
