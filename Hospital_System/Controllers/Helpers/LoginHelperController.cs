using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospital_System.Data;
using Hospital_System.Models;

namespace Hospital_System.Controllers.Helpers
{
    public class LoginHelperController : Controller
    {
        public static HSDbContext db = new HSDbContext();
        // GET: LoginHelper
        public static User CheckUserExistLogin(string username, string password)
        {
            User user = new User();
            var users = db.Users.Where(x => x.userName == username && x.password == password).FirstOrDefault();
            user = users;
            return user;
        }
    }
}