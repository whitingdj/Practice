using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace PracticeDroid {
    [Activity(Label = "PracticeDroid", Icon = "@drawable/picycle")]
    public class Ride : Activity {

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Button button = FindViewById<Button>(Resource.Id.);

        }
    }
}

