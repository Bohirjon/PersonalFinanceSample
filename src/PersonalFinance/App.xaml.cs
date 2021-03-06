﻿using PersonalFinance.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalFinance
{
    public partial class App : Application
    {

        public App ()
        {
            Device.SetFlags(new string[] {
                "Shell_UWP_Experimental"
            });

            App.Current.UserAppTheme = OSAppTheme.Light;

            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
