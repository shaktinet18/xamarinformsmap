using Ezi.CustomMap.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TK.CustomMap.Api.Google;
using Xamarin.Forms;

namespace Ezi.CustomMap
{
    public class App : Application
    {
        public App()
        {
            GmsPlace.Init("AIzaSyDx0rnc6jDr5VtGYgqhDQ3VvanZ1ko4S9M");
            GmsDirection.Init("AIzaSyDx0rnc6jDr5VtGYgqhDQ3VvanZ1ko4S9M");
            // The root page of your application
            var content = new ContentPage
            {
                Title = "Ezi.CustomMap",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
            var mainPage = new NavigationPage(new SamplePage());
            if (Device.OS == TargetPlatform.iOS)
            {
                mainPage.BarBackgroundColor = Color.FromHex("#f1f1f1");
            }
            MainPage = mainPage;
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
