using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WalkthroughCarousel
{
    public partial class WalkthroughStepThreePage : ContentPage
    {
        public WalkthroughStepThreePage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
