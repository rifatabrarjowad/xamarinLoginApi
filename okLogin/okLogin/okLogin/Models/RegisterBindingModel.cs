using System;
using System.Collections.Generic;
using System.Text;

namespace okLogin.Models
{
    public class RegisterBindingModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
