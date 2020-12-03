using System.Web;
using System.Web.Mvc;

namespace JH_ECHARS_PLUGIN
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
