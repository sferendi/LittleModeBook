﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;


namespace MyLittleModeBook
{
    
    [Activity(Label = "My Little Mode Book", MainLauncher = true)]
    public class MainActivity : Activity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            ImageView logo = (ImageView)FindViewById<ImageView>(Resource.Id.logo);
            var scaleButton = FindViewById<Button>(Resource.Id.button1);
            var mediaButton = FindViewById<Button>(Resource.Id.button2);
            var aboutButton = FindViewById<Button>(Resource.Id.button3);
            logo.SetImageResource(Resource.Drawable.book);

            scaleButton.Click += delegate {
                Intent scaleAct = new Intent(this, typeof(Main2Activity));
                StartActivity(scaleAct);
            };

            mediaButton.Click += delegate {
                Intent mediaAct = new Intent(this, typeof(Main3Actiity));
                StartActivity(mediaAct);
            };

            aboutButton.Click += delegate {
                Intent aboutAct = new Intent(this, typeof(Main4Activity));
                StartActivity(aboutAct);
            };
            // Set our view from the "main" layout resource

        }

        
    }
}

