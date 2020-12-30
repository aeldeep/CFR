using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegisterNewUser.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User U)
        {
            if(ModelState.IsValid)
            {
                using(UsersEntities us = new UsersEntities())
                {
                    U.Password=Encode.EncodePasswordToBase64(U.Password);
                    U.ConfirmPassword= U.Password;
                    us.Users.Add(U);
                    us.SaveChanges();
                    ModelState.Clear();
                    U = null;
                    ViewBag.Message = "User Registered Successfully";
                }
            }
            return View(U);
        }
    }

}