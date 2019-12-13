using System.Web;
using System.Web.Mvc;

namespace El_Reciclaje_G_G
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
