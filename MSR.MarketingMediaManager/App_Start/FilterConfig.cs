using System.Web;
using System.Web.Mvc;

namespace MSR.MarketingMediaManager
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
