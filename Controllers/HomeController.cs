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

        public IActionResult AllEquipment() {
            var allEquipment = Repository.AllEquipment;
            return View(allEquipment);
        }

        // Action to display only available equipment
        public IActionResult AvailableEquipment() {
            var availableEquipment = Repository.AllEquipment
                .Where(e => e.Availability == "Yes")
                .ToList(); // Convert to a List to match the view model
            return View(availableEquipment);
        }
    }
}