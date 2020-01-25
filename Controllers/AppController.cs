using Dutch_Treat.Services;
using Dutch_Treat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Dutch_Treat.Controllers
{
    public class AppController : Controller
    {
        private readonly INullMailService _mailService;

        public AppController(INullMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

      [HttpGet("contact")]  public IActionResult Contact()
        {
            
            return View();
        }
        
      
      [HttpPost("contact")]  public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage(model.Email,model.Subject,model.Message);
                ViewBag.UserMessage = "Mail Sent";
            }
            return View();
        }



        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}