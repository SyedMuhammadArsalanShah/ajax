using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class User
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday{ get; set; }
        public Role role { get; set; }
     

        
    }
    public enum Role
    {
        Admin,Normal, Guest

    }



}