
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
using Newtonsoft.Json;

namespace MyLittleModeBook
{
    [Activity(Label = "ScaleListActivity")]
    public class ScaleListActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ScaleDisplayScreen);
            Button backToListButton = (Button)FindViewById<Button>(Resource.Id.backToList);
            ImageView emoticon = (ImageView)FindViewById<ImageView>(Resource.Id.moodImage);
            TextView scaleTitle = (TextView)FindViewById<TextView>(Resource.Id.currentscale);
            TextView scaleInformation = (TextView)FindViewById<TextView>(Resource.Id.scaleInformation);
            var scaleSetAs = JsonConvert.DeserializeObject<ScaleClass>(Intent.GetStringExtra("scale"));
            scaleTitle.Text = scaleSetAs.name;
            scaleInformation.Text = scaleSetAs.notes;

            if (scaleSetAs.tone == "happy")
            {
                emoticon.SetImageResource(Resource.Drawable.happy);
            } else if (scaleSetAs.tone == "sad")
            {
                emoticon.SetImageResource(Resource.Drawable.sad);
            }


            backToListButton.Click += BackToListButton_Click;
            // Create your application here
        }

        void BackToListButton_Click(object sender, EventArgs e)
        {
            Intent backToList = new Intent(this, typeof(Main2Activity));
            StartActivity(backToList);
        }

    }
}
