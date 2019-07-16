﻿using System;
using BasicXamarinApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace BasicXamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new IssueListPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}