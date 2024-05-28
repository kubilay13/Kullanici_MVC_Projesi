using Kullanıcı_MVC_Projesi.Models;
using Microsoft.AspNetCore.Mvc;


namespace Kullanıcı_MVC_Projesi.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }
        
        public IActionResult Apply() 
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Apply([FromForm]Candidate model)
        {
            Repository.Add(model);
            return View("Feedback",model);
        }
        

    }
}
