using System;

using Xamarin.Forms;

namespace AdMobTest
{
	public class BannerView : View {}

	public class App : Application
	{
		public App()
		{
			// The root page of your application
			var content = new ContentPage
			{
				Title = "AdMobTest",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						new BannerView()
					}
				}
			};

			MainPage = new NavigationPage(content);
		}
	}
}
