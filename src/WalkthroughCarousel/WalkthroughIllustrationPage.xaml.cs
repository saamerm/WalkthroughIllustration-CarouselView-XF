using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WalkthroughCarousel
{
    public partial class WalkthroughIllustrationPage : CarouselPage
    {
        public WalkthroughIllustrationPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}
