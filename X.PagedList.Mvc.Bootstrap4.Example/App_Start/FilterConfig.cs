using System.Web;
using System.Web.Mvc;

namespace X.PagedList.Mvc.Bootstrap4.Example
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
