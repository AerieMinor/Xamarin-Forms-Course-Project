﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyRSVPMobile.ViewModels;
using MyRSVPMobile.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyRSVPMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            

            MainPage = new Views.Login();
                       
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
