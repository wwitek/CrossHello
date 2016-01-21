using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrossHello.Mobile.Views;
using Xamarin.Forms;

namespace CrossHello.Mobile
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new MainWindow();
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
