using System.Web;
using System.Web.Mvc;

namespace CRM_Module_Phase_one
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
