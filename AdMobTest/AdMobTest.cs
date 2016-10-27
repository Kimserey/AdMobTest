using System;

using Xamarin.Forms;

namespace AdMobTest
{
	public class BannerView : View {}

	public class NextPage : ContentPage { }

	public class App : Application
	{
		public App()
		{
			var layout = new AbsoluteLayout();

			layout.Children.Add(
				new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Ads test!" }, 
				new Rectangle(0.5, 0.5, 0.5, 0.5),
				AbsoluteLayoutFlags.All);
			
			layout.Children.Add(
				new BannerView(),
				new Rectangle(0, 1, 1, 1),
				AbsoluteLayoutFlags.All);
			
			var content = new ContentPage
			{
				Title = "Ads test",
				Content = layout
			};

			MainPage = new NavigationPage(content);
		}
	}
}
