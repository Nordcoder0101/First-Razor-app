using Microsoft.AspNetCore.Mvc;

namespace razor_fun
{
  public class IndexController : Controller
  {
    [HttpGet]
    [Route("")]
    public ViewResult index()
    {
      return View();
    }
  }
}