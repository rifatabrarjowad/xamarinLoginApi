using RegLoginApp.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
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
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(x => x.UserName.Equals(username.Text) && x.Password.Equals(password.Text)).FirstOrDefault();

            if(myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new Home());
            }
            else
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Device.BeginInvokeOnMainThread(async () =>
                    {
                        var result = await this.DisplayAlert("Congratulation", "User Register Sucessfull", "es", "Cancel");
                        if (result)
                        {
                            await Navigation.PushAsync(new LoginPage());
                        }
                        else
                        {
                            await Navigation.PushAsync(new LoginPage());
                        }
                    });

                });
            }

        }
    }
}