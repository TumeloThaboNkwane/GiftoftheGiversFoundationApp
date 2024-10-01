using GiftoftheGiversFoundationApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GiftoftheGiversFoundationApp.Controllers
{
    public class HomeController : Controller
    {
        // Home Page
        public IActionResult Index()
        {
            return View();
        }

    
        public IActionResult Donation(string resourceType, int quantity, string province, string city, string description)
        {
            // Handle the donation logic (save to database, send notifications, etc.)
            // For now, just redirect back to the page with a success message

            
            return View();
        }

        // Action for displaying the incident report submission page
        public IActionResult SubmitReport()
        {
            return View();
        }

        // Login Page
        public IActionResult Login(string Email, string Password)
        {
            // Handle login logic here
            // For now, just redirect back to the home page
            return View();
        }

        // Register Page
        public IActionResult Register(string FirstName, string LastName, string Email, string Password)
        {
            // Handle registration logic here
            // For now, just redirect back to the home page

            // Set success message
            ViewBag.Message = "Registration successful! You will be redirected to the login page shortly.";

            return View();
        }
        public IActionResult Volunteer(string name, string email, string phone, string skills)
        {
            // Logic to save volunteer registration can go here.

            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Newsletter(NewsletterSignup signup)
        {
            if (ModelState.IsValid)
            {
                // Here, you can add logic to save the email to your database or send a confirmation email.
                ViewBag.Message = "Thank you for subscribing to our newsletter!";
                return View("Newsletter");
            }

            return View("Newsletter");
        }
        public IActionResult Dashboard() // Ensure this matches your view name
        {
            var model = new AdminDashboardViewModel();
            return View(model); // This will look for Views/Admin/Dashboard.cshtml
        }

         public IActionResult Events()
        { 
        return View();
         }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        // POST: Send Reset Link
        [HttpPost]
        public IActionResult SendResetLink(string email)
        {
            // Here you would add your logic to send the reset link email.
            // For example, generate a token and send an email to the user.

            // Dummy success message for now
            ViewBag.Message = "A password reset link has been sent to your email address.";
            return View("ForgotPassword");
        }

        public IActionResult UserDashboard()
        {
            return View();
        }



    }





}
