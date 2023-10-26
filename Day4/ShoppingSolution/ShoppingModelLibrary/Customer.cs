using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingModelLibrary
{
    public class Customer
    {
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; } =0;
        private string password;
        public string Password { 
            get {
                return GetMaskedPassword();
            }
            set
            {
                password = value;
            }
        } 
        public string Phone { get; set; } = string.Empty;
        public Customer()
        {
            
        }
        public Customer(string email, int age, string password, string phone)
        {
            Email = email;
            Age = age;
            Password = password;
            Phone = phone;
        }
        public bool ComparePassword(string userPassword)
        {
            return (password==userPassword)?true:false; ;
        }
        string GetMaskedPassword()
        {
            var len = password.Length;
            string maskedPass = password.Substring(0, 2);
            for (int i = 2; i < len; i++)
            {
                maskedPass += "*";
            }
            return maskedPass;
        }
        public override string ToString()
        {
            string maskedPass = GetMaskedPassword();
            return $"Email : {Email}\nAge : {Age}\nPhone : {Phone}\nPassword : {maskedPass}";
        }
    }
}
