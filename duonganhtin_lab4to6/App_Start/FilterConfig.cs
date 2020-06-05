using System.Web;
using System.Web.Mvc;

namespace duonganhtin_lab4to6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
