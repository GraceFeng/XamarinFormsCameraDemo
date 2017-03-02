using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FormsCamera
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new FormsCamera.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        public static ImageSource source;

        protected override void OnResume()
        {
            // Handle when your app resumes
            MainPage = new FormsCamera.MainPage();
        }
    }
}