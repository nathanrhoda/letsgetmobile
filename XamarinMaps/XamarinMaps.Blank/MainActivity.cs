using Android.App;
using Android.Gms.Maps;
using Android.Widget;
using Android.OS;

namespace XamarinMaps.Blank
{
    [Activity(Label = "XamarinMaps.Blank", MainLauncher = true)]
    public class MainActivity : Activity, IOnMapReadyCallback
    {
        private GoogleMap _googleMap;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);
           // SetUpMap();
            Android.Webkit.WebView webView = (Android.Webkit.WebView)FindViewById(Resource.Id.webView);
            webView.Settings.JavaScriptEnabled = true;
            webView.LoadUrl("http://maps.googleapis.com/maps/api/staticmap?ll=36.97,%20-122&lci=bike&z=13&t=p&size=500x500&sensor=true");

        }

        private void SetUpMap()
        {
            if (_googleMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.webView).GetMapAsync(this);

            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            _googleMap = googleMap;
        }
    }
}

