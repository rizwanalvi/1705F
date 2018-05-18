using MVCAUTHORIZATION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCAUTHORIZATION.Login
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User u, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                string struName = Convert.ToString(u.UserName).ToUpper().Trim();
                string strPassword = Convert.ToString(u.passWord).ToUpper().Trim();

                //Verify credentials against database in real project
                if (struName == "123@123.com".ToUpper() && strPassword == "123".ToUpper())
                {
                    FormsAuthentication.SetAuthCookie(u.UserName.ToUpper(), false);
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Home", "Testq");
                    }
                }
                else
                {
                    ModelState.AddModelError("authenticationError",
            "User name or Password is wrong. Try it again");
                    //lblError.Text = "User name or Password is wrong. Try it again";
                }
            }
            return View(u);
        }
    }
}