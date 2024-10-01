using GiftoftheGiversFoundationApp.Models;  // Assuming Disaster, Donation, and Volunteer models exist
using Microsoft.AspNetCore.Mvc;
using GiftoftheGiversFoundationApp.ViewModels; // Add this if it's not there



namespace GiftoftheGiversFoundationApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Login
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Replace this with your actual login validation logic
                if (model.Username == "admin" && model.Password == "password") // Example logic
                {
                    // Redirect to the Dashboard if login is successful
                    return RedirectToAction("Dashboard", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }
            return View(model); // Return to the login view with error
        }
        public IActionResult Index()
        {
            return View();
        }


        // GET: Admin/Dashboard
        [HttpGet]
        public IActionResult Dashboard() // Ensure this matches your view name
        {
            var model = new AdminDashboardViewModel();
            return View(model); // This will look for Views/Admin/Dashboard.cshtml
        }

        [HttpPost]
        public IActionResult ApproveVolunteer(int id)
        {
            // Approve volunteer logic (empty for now)
            return RedirectToAction("Dashboard");
        }

    }
}
