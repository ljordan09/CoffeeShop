using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShopApp.Models
{
    public class SignUps
    {

        private string firstname;
        private string lastname;
        private string email;
        private string phone;
        private string password;

        public SignUps(): this("","","","","")
        {
            
        }

        public SignUps(string firstname, string lastname, string email, string phone, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.password = password;
        }

       

        public string FirstName
        {
            set { firstname = value; }
            get { return firstname; }
        }
        public string LastName
        {
            set { lastname = value; }
            get { return lastname; }
        }

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

    }
}