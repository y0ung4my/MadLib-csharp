using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
		// the following uses route decorator
    [Route("/hello")]
    // without the above line, the url would have to include "home/hello" rather than just "/home" at the end
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    // Below is the root path, or homepage
    [Route("/")]
    public string Letter() { return "Our virtual postcard will go here soon!"; }

  }
}