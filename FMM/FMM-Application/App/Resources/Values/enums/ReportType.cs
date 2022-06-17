using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMM_Application.App.Resources.Values.enums
{
   public sealed class ReportType
{
    public static readonly string QUALITY = " جودة ";
    public static readonly string MAINTENANCE = " صيانة ";

    public List<string> getValues()
    {
        return new List<string>
        {
            QUALITY,
            MAINTENANCE
        };
    }

}
}
