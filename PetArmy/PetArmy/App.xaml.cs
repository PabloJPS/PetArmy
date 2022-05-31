﻿using PetArmy.Services;
using PetArmy.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetArmy
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            //_ = Shell.Current.GoToAsync("//LoginPage");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
