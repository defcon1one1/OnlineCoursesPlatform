using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using OnlineCoursesPlatform.Models;



namespace OnlineCoursesPlatform.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


    }
}
