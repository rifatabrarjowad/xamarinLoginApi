using okLogin.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace okLogin.ViewModel
{
    public class RegisterViewModel
    {
        ApiServices _apiServices = new ApiServices();
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Massage { get; set; }
        public ICommand RegisterCommand
        {
            get 
            {
                return new Command(async () =>
                {
                   var isSucess = await _apiServices.RegisterAsync(UserName, Password, ConfirmPassword);
                    if (isSucess)
                    {
                        Massage = "Register sucessfull";
                    }
                    else
                    {
                        Massage = "try again later";
                    }
                        
                });
            }
        }


    }
}
