using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegLoginApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
    
        async void HaveAccount(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Register());
                         
        }
        async void LogInAcc(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Register());

        }
    }
}