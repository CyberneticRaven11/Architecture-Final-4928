using System.Web;
using System.Web.Mvc;

namespace Architecture_Final_4928
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
