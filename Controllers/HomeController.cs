using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SocialMediaLinks.Models;

namespace SocialMediaLinks.Controllers
{
	public class HomeController : Controller
	{
		private readonly SocialMediaLinkOptions _socialMediaLinkOptions;

		public HomeController(IOptions<SocialMediaLinkOptions> socialMediaLinkOptions)
		{
			_socialMediaLinkOptions = socialMediaLinkOptions.Value;
		}

		[Route("/")]
		public IActionResult Index()
		{
			ViewBag.Links = _socialMediaLinkOptions;
			return View();
		}
	}
}
