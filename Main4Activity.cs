
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MyLittleModeBook
{
    [Activity(Label = "Main4Activity")]
    public class Main4Activity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main4Activity);
            ImageView about = (ImageView)FindViewById<ImageView>(Resource.Id.webPic);
            Button goToGitHub = (Button)FindViewById<Button>(Resource.Id.toGithub);
            Button backToHomeWeb = (Button)FindViewById<Button>(Resource.Id.backWebHome);
            about.SetImageResource(Resource.Drawable.about);
            backToHomeWeb.Click += BackToHomeWeb_Click;
            goToGitHub.Click += GoToGitHub_Click;
            // Create your application here
        }

        void BackToHomeWeb_Click(object sender, EventArgs e)
        {
            Intent backWHome = new Intent(this, typeof(MainActivity));
            StartActivity(backWHome);
        }

        void GoToGitHub_Click(object sender, EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://github.com/sferendi/LittleModeBook");
            Intent goToWeb = new Intent(Intent.ActionView, uri);
            StartActivity(goToWeb);
        }

    }
}
