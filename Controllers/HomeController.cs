using Microsoft.AspNetCore.Mvc;
using EquipmentRequest.Models;
namespace EquipmentRequest.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }
        [HttpGet]
        public ViewResult RequestForm() {
            return View();
        }
        [HttpPost]
        public ViewResult RequestForm(UserRequest userRequest) {
            if (ModelState.IsValid) {
                Repository.AddRequests(userRequest);
                return View("Thanks", userRequest);
            } else {
                return View();
            }
        }
        public ViewResult ListRequests() {
            return View(Repository.Requests);
            //return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}