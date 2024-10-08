using System.Web;
using System.Web.Mvc;

namespace NguyenThanhToan_KTFE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
