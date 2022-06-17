using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class DepositName
{
    public static readonly string DEPOSIT_CHEQUE = " شيك الإيداع ";
    public static readonly string CASH_DEPOSIT = " إيداع نقدي ";
    public static readonly string CASH_TRANSFER_TO_AN_ACCOUNT = "  التحويل النقدي لحساب ";
    public static readonly string BANK_INTEREST_RATE = "معدل الفائدة البنكية  ";
    public static readonly string ADDITION_SETTLEMENT = " تسوية بالإضافة";
    public static readonly string THE_BALANCE_OF_THE_FIRST_DURATION = " رصد أول المدة  ";

    public List<string> getValues()
    {
        return new List<string>
        {
            DEPOSIT_CHEQUE,
            CASH_DEPOSIT,
            CASH_TRANSFER_TO_AN_ACCOUNT,
            BANK_INTEREST_RATE,
            ADDITION_SETTLEMENT,
            THE_BALANCE_OF_THE_FIRST_DURATION
        };
    }
}
}
