using Microsoft.AspNetCore.Mvc;
using Registration_Form.DAL;

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

            UserRegistrationViewModel userVM = new UserRegistrationViewModel();
            return View(userVM);
        }
        [HttpPost]
        public IActionResult Registration(UserRegistrationViewModel userVM)
        {
			MvcpracticeContext db = new MvcpracticeContext();
			
			if (ModelState.IsValid == true)
            {
                //Convert from UserViewModel to UserDTO model
                User user = new User(); //DTO
                user.Email = userVM.Email;
                user.FirstName = userVM.FirstName;
                user.LastName = userVM.LastName;
                user.GendersId = userVM.GendersId;
                user.MobileNumber = userVM.MobileNumber;
                user.Password = userVM.Password;
                user.AdharNumber = userVM.AdharNumber;


                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index","Home");
            }
			var genders = db.Genders.ToList();
			ViewBag.GenderList = genders;

			return View(userVM);
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
