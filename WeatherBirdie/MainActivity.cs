using Android.App;
using Android.Widget;
using Android.OS;

namespace WeatherBirdie
{
	[Activity (Label = "WeatherBirdie", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			Button search = FindViewById<Button> (Resource.Id.search);
			search.Click += searchWeatherForLocation;
		}

		//Fetches the weather for the location in the text box
		private void searchWeatherForLocation(object o, System.EventArgs ea){

			EditText searchbox = FindViewById<EditText> (Resource.Id.searchText);
			string searchDetails = searchbox.Text;
			if(searchDetails == null || searchDetails.Equals("")){
				//Handling for no location in the text box
				return;
			}

			//Start Weather Details Activity
			StartActivity(typeof(WeatherDetails));
		}
			
	}
}


