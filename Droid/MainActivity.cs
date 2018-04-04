using Android.App;
using Android.Widget;
using Android.Graphics;
using Android.OS;

namespace CrossPlatformApp.Droid {
	
	[Activity(Label = "CrossPlatformApp", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity {
		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.Main);
			setupButton();
		}

		private Color getRandomColor() {
			return (Color.HSVToColor(new float[] { MyClass.getRandomColorValue(), 1.0f, 1.0f }));
		}

		private void setupButton() {
			// Set Button Click to Change Background's Color
			(FindViewById<Button>(Resource.Id.myButton)).Click += 
				delegate { (FindViewById<LinearLayout>(Resource.Id.main_view)).SetBackgroundColor(getRandomColor()); };
		}
	}
}