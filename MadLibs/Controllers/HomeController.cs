using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }
  
    [Route("/madlib1")]
    public ActionResult ComplexMadLib(string adjective1, string noun1, string verbPT1, string adverb1, string adjective2, string noun2, string noun3, string adjective3, string verb2, string adverb2, string verbPT2, string adjective4)
    {
      LibsVariable newLibsVariable = new LibsVariable();
      newLibsVariable.Adjective1 = adjective1;
      newLibsVariable.Noun1 = noun1;
      newLibsVariable.VerbPT1 = verbPT1;
      newLibsVariable.Adverb1 = adverb1;
      newLibsVariable.Adjective2 = adjective2;
      newLibsVariable.Noun2 = noun2;
      newLibsVariable.Noun3 = noun3;
      newLibsVariable.Adjective3 = adjective3;
      newLibsVariable.Verb2 = verb2;
      newLibsVariable.Adverb2 = adverb2;
      newLibsVariable.VerbPT2 = verbPT2;
      newLibsVariable.Adjective4 = adjective4;
      return View(newLibsVariable);
    }

    [Route("/madlib2")]
    public ActionResult SimpleMadLib(string adjective1, string noun1, string verbPT1)
    {
      LibsVariable newLibsVariable = new LibsVariable();
      newLibsVariable.Adjective1 = adjective1;
      newLibsVariable.Noun1 = noun1;
      newLibsVariable.VerbPT1 = verbPT1;
    
      return View(newLibsVariable);
    }
  }
}
