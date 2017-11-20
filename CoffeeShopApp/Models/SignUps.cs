using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopApp.Models
{
    public class SignUps
    {

        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string password;
        private string favflavor;
        private string favlocation;
        private string zip;

        public SignUps(): this("","","","","","","","")
        {
            
        }

        public SignUps(string firstname, string lastname, string email, string phone, string password, string favflavor, string favlocation, string zip)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.password = password;
            this.favlocation = favlocation;
            this.favflavor = favflavor;
            this.zip = zip;
        }


        
        [Required(ErrorMessage = "Name required")]//data annotation
        [RegularExpression("^[A-Za-z]$", ErrorMessage = "Must be letters")]
        public string FirstName
        {
            set { firstname = value; }
            get { return firstname; }
        }

       
        [Required(ErrorMessage = "Name required")]//data annotation
        public string LastName
        {
            set { lastname = value; }
            get { return lastname; }
        }

        [Required]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Must be a valid email. ")]
        public string Email
        {   
            set { email = value; }
            get { return email; }
        }
        public string Phone
        {
            set { phone = value; }
            get { return phone; }
        }
       
        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public string FavFlavor
        {
            set { favflavor = value; }
            get { return favflavor; }
        }

        public string FavLocation
        {
            set { favlocation = value; }
            get { return favlocation; }
        }

        public string Zip
        {
            set { zip = value; }
            get { return zip; }
        }

    }
}