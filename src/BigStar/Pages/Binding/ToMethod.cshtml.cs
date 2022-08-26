using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BigStar.Pages.Binding
{

	public class ToMethodModel : PageModel
	{
		public string CardName { get; set; }
		public decimal? OriginalPrice { get; set; }
		public void OnGet()
		{
		}
	}
}
