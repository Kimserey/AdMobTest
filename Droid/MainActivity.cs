using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AdMobTest;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;

[assembly: ExportRenderer(typeof(BannerView), typeof(AdMobTest.Droid.BannerViewRenderer))]
namespace AdMobTest.Droid
{
	public class BannerViewRenderer: ViewRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement == null)
			{
				var adView = new AdView(this.Context);
				adView.AdSize = AdSize.Banner;
				adView.AdUnitId = this.Context.GetString(Resource.String.banner_ad_unit_id);

				var requestbuilder = new Android.Gms.Ads.AdRequest.Builder();
				adView.LoadAd(requestbuilder.Build());

				SetNativeControl(adView);
			}
		}

	}

	[Activity(Label = "AdMobTest.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new AdMobTest.App());
		}
	}
}
