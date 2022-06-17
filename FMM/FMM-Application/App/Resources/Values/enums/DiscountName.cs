using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
    class DiscountName
{
    public static readonly string CASH_CHEQUE = " صرف الشيك ";
    public static readonly string CASHING = " نقداً ";
    public static readonly string BANK_INTREST_RATE = "معدل الفائدة المصرفية";
    public static readonly string CASH_TRANSFER_TO_AN_ACCOUNT = " التحويل النقدي لحساب";
    public static readonly string BANKING_EXPENSES = " المصاريف المصرفية";
    public static readonly string SETTLEMENT_DISCOUNT = " خصم التسوية";

    public List<string> getValues()
    {
        return new List<string>
        {
            CASH_CHEQUE,
            CASHING,
            BANK_INTREST_RATE,
            CASH_TRANSFER_TO_AN_ACCOUNT,
            BANKING_EXPENSES,
            SETTLEMENT_DISCOUNT
        };
    }
}
}
