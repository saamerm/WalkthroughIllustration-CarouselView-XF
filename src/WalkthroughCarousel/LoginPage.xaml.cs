using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace WalkthroughCarousel
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            var hasRunIntro = Preferences.Get("HasRunIntro", false);
            if (!hasRunIntro)
            {
                Preferences.Set("HasRunIntro", true);

                var modalPage = new WalkthroughIllustrationPage();
                await Navigation.PushModalAsync(modalPage);
            }
        }
    }
}
