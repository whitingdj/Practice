using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PracticeDroid {
    [Activity(Label = "PracticeDroid", MainLauncher = true, Icon = "@drawable/picycle")]
    public class MainActivity : Activity {

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button rideButton = FindViewById<Button>(Resource.Id.rideButton);

            rideButton.Click += RideButton_Click;

        }

        private void RideButton_Click(object sender, EventArgs e) {
            SetContentView(Resource.Layout.Ride);
        }
    }
}

