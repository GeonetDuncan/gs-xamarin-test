// It worked! I'm awesome
using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MultipageApp
{
	[Activity (Label = "MultipageApp", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			Button aboutUs = FindViewById<Button> (Resource.Id.about);

			aboutUs.Click += (object sender, EventArgs e) => {
				var intent = new Intent(this, typeof(AboutUsActivity));

				StartActivity(intent);
			};
		}
	}
}