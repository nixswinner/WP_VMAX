using com.vmax.windows.ads;
using com.vmax.windows.ads.wp81;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VungleSDK;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace WinApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //add link here--->
        private string link = "https://www.okcupid.com/";
        //......................................................//
        //Vmax id
        //Banner
        string BannerKey = "d1ec84b5";
        //Intertistial
        string IntertialKey = "V56932057";
        //........................................................................................................................
        VMAXAdView adView = new VMAXAdView(); // To initialize the VMAXAdView intertial video
        VMAXAdView banner = new VMAXAdView(); // To initialize the VMAXAdView banner


        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            //Vmax.....
            adView.AdspotId = IntertialKey; // To specify the Adspot Id. Replace “MY_ADSPOT_ID” with your actual Adspot Id.
            adView.UX = AdUX.Interstitial; // To specify intertial ads.
            adView.DidCacheAd += AdView_DidCacheAd;
            adView.DidLoadAd += AdView_DidLoadAd;
            adView.FailedToLoadAd += AdView_FailedToLoadAd;
            adView.LoadAd();
            adView.ShowAd();
            //....
            //Banners
            TopBanner.AdspotId = BannerKey;
            TopBanner.FailedToCacheAd += TopBanner_FailedToCacheAd;
            TopBanner.DidCacheAd += TopBanner_DidCacheAd;
            TopBanner.DidLoadAd += TopBanner_DidLoadAd;
            TopBanner.LoadAd();
            TopBanner.ShowAd();
            //bottom
            BottomBanner.AdspotId = BannerKey;
            BottomBanner.FailedToCacheAd += BottomBanner_FailedToCacheAd;
            BottomBanner.DidCacheAd += BottomBanner_DidCacheAd;
            BottomBanner.DidLoadAd += BottomBanner_DidLoadAd;
            BottomBanner.LoadAd();
            BottomBanner.ShowAd();

        }

        private void BottomBanner_DidLoadAd(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Banner loaded cached successfully");
            BottomBanner.LoadAd();
            BottomBanner.ShowAd();
        }

        private void BottomBanner_DidCacheAd(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Banner loaded cached successfully");
            BottomBanner.LoadAd();
            BottomBanner.ShowAd();
        }

        private void BottomBanner_FailedToCacheAd(object sender, VMAXAdView.AdFailedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Failed to cache banner ad with error " + e.ToString());
        }

        private void TopBanner_DidLoadAd(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Banner loaded cached successfully");
            TopBanner.LoadAd();
            TopBanner.ShowAd();
        }

        private void TopBanner_DidCacheAd(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Banner loaded cached successfully");
            TopBanner.LoadAd();
            TopBanner.ShowAd();
        }

        private void TopBanner_FailedToCacheAd(object sender, VMAXAdView.AdFailedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Failed to cache banner ad with error " + e.ToString());
        }

        private void AdView_DidLoadAd(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Ad received successfully");
            adView.LoadAd(); // This will load the Ad and on success provides a callBack named DidLoadAd. You need to handle this to perform any action on this event in your application.

            adView.ShowAd();
        }

        private void AdView_DidCacheAd(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Ad cached successfully");
            adView.LoadAd();
            adView.ShowAd();
        }
        //failed to load
        private void AdView_FailedToLoadAd(object sender, VMAXAdView.AdFailedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Failed to cache Intertial ad with error " + e.ToString());
        }

        //Event handler for OnAdPlayableChanged event
      

       

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }


        private void WebView_Loaded(object sender, RoutedEventArgs e)
        {
            //add url
            // Add your URL here
            Browser.Navigate(new Uri(link, UriKind.RelativeOrAbsolute));
            loadtxt.Visibility = Visibility.Visible;


        }

        private async void WebView_NavigationFailed(object sender, WebViewNavigationFailedEventArgs e)
        {

            MessageDialog msgbox = new MessageDialog("Oops!Sorry there seams to be a problem without your internet connection.\n Please try again");
            await msgbox.ShowAsync();
            //navigating back
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.GoBack();
        }

        private void Browser_LoadCompleted(object sender, NavigationEventArgs e)
        {
            loadtxt.Visibility = Visibility.Collapsed;
        }



        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>



    }
}
