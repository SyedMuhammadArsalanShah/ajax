using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class AjaxUserController : Controller
    {
        // GET: AjaxUser
        public ActionResult Index()
        {
            return View();
        }


        private readonly User[] userdata =
        {
            new User{FirstName ="Arsalan" ,Lastname="Shah",Birthday = new DateTime(2001,4,18) ,role = Role.Normal},
            new User{FirstName ="Ali" ,Lastname="Shah",Birthday = new DateTime(2001,4,18) ,role = Role.Normal},
            new User{FirstName ="Affan" ,Lastname="Shah",Birthday = new DateTime(2001,4,18) ,role = Role.Admin},
            new User{FirstName ="Hassan" ,Lastname="Shah",Birthday = new DateTime(2001,4,18) ,role = Role.Admin},
            new User{FirstName ="Shahid" ,Lastname="Shah",Birthday = new DateTime(2001,4,18) ,role = Role.Guest},



        };




        public ActionResult GetUserData(string selectedrole ="All")
        {

            IEnumerable data = userdata;

            if (selectedrole != "All")
            {

                var selected = (Role)Enum.Parse(typeof(Role), selectedrole);

                data = userdata.Where(p => p.role == selected);





            }

            return View(data);
        }


        public ActionResult GetUser(string selectedrole = "All")
        {
            return View((object)selectedrole);

        }


        }
}