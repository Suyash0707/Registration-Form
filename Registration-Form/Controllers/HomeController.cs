using Microsoft.AspNetCore.Mvc;

namespace Registration_Form.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { 
          return View();
        }

        [HttpGet]
        public IActionResult Registration()
        {
            MvcpracticeContext db = new MvcpracticeContext();
            var genders = db.Genders.ToList();
            
            ViewBag.GenderList = genders;
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public IActionResult Registration(User user)
        {
			MvcpracticeContext db = new MvcpracticeContext();
			
			if (ModelState.IsValid == true)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }
			var genders = db.Genders.ToList();
			ViewBag.GenderList = genders;

			return View(user);
        }

        public IActionResult IsEmailIdValid(string Email)
        {
            MvcpracticeContext db = new MvcpracticeContext();
            var isEmailIdPresentInDB = db.Users.Any(u => u.Email == Email);

            if (isEmailIdPresentInDB == true)
            {
                return Json("Entered Email already Exist. Please enter different Email.");
            }
            else
            {
                return Json(true);
            }
            
        }

    }
}
