﻿using RegLoginApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RegLoginApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Register();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
