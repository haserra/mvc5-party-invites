using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        
        // alternative instance variables or fields
        //string name;

        //string email;

        //string phone;

        //bool willAttend;


            // correspondent getters and setters
        //public string Name
        //{
        //    get 
        //    {
        //        return name;
        //    }
        //    set 
        //    {
        //        name = value;
        //    }
        //}

        //public string Email
        //{
        //    get
        //    {
        //        return email;
        //    }
        //    set
        //    {
        //        email = value;
        //    }

        //}

        //public string Phone
        //{
        //    get
        //    {
        //    }
        //    set
        //    {
        //    }

        //}

        //public string WillAttend
        //{
        //    get
        //    {
        //    }
        //    set
        //    {
        //    }

        //}

            //using Properties instead

        [Required(ErrorMessage ="Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter your email address.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please enter a valid email address.")]        
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter your phone number.")]
        public string Phone { get; set; }

        // the WillAttend property is a nullable bool, which means that it can be true, false, or null.
        [Required(ErrorMessage ="Please indicate whether you'll attend.")]
        public bool? WillAttend { get; set; }

    }
}