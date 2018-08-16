
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
    [Activity(Label = "Main3Actiity")]
    public class Main3Actiity : Activity
    {
        String[] playArray = { "C Major", "C Minor", "C Minor Pentatonic", "C Dorian", "C Melodic Minor", "C Harmonic Minor", "C Lydian", "C Mixolydian" };
        private ArrayAdapter<string> mediaAdapt;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main3Activity);
            Button backToHome = (Button)FindViewById<Button>(Resource.Id.backToHome);

            mediaAdapt = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, playArray);
            ListView mediaList = (ListView)FindViewById<ListView>(Resource.Id.listenList);
            mediaList.Adapter = mediaAdapt; 
            backToHome.Click += BackToHome_Click;
            mediaList.ItemClick += MediaList_ItemClick;
            // Create your application here
        }

        void BackToHome_Click(object sender, EventArgs e)
        {
            Intent backToHomePage = new Intent(this, typeof(MainActivity));
            StartActivity(backToHomePage);
        }

        void MediaList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent mediaAct = new Intent(this, typeof(MediaPlay));
            string sendScale = playArray[e.Position];
            mediaAct.PutExtra("media", sendScale);
            StartActivity(mediaAct);
        }

    }
}
