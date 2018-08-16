
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
    [Activity(Label = "Main2Activity")]
    public class Main2Activity : Activity
    {
        private ArrayAdapter<string> listAdapt;
        public ScaleClass[] scaleDetails = new ScaleClass[8];
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main2Activity);
            String[] scaleNames = { "Major", "Minor", "Pentatonic", "Dorian", "Melodic Minor", "Harmonic Minor", "Lydian", "Mixolydian"};
            listAdapt = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, scaleNames);
            ListView scaleList = (ListView)FindViewById<ListView>(Resource.Id.scalelist);
            Button backButton = (Button)FindViewById<Button>(Resource.Id.backButton);
            scaleList.Adapter = listAdapt;
            ScaleClass major = new ScaleClass("Major", "The major scale is a happy scale\n that has this as a structure: \nTone-Tone-Semitone\nTone-Tone-Tone-SemiTone\n For example, \n the notes in the C Major scale are: \n C-D-E-F-G-A-B", "happy", 0);
            scaleDetails[0] = major;
            ScaleClass minor = new ScaleClass("Minor", "The minor scale is a happy scale\n that has this as a structure: \nTone-SemiTone-Tone\nTone-SemiTone-Tone-Tone\n For example, \n the notes in the C Minor scale are: \n C-D-D#-F-G-G#-A#", "sad", 1);
            scaleDetails[1] = minor;
            ScaleClass pentatonic = new ScaleClass("Minor Pentatonic", "The minor pentatonic scale is a sad scale\n that has this as a structure: \nFirst-Flat Third\nFourth-Fifth-Flat Seventh\n For example, \n the notes in the C Minor Pentatonic scale are: \n C-D#-F-G-A#", "sad", 2);
            scaleDetails[2] = pentatonic;
            ScaleClass dorian = new ScaleClass("Dorian", "The dorian mode is a sad mode\n that has this as a structure: \nTone-Tone-Semitone\nTone-Tone-Tone-SemiTone\n For example, \n the notes in the C Major scale are: \n C-D-E-F-G-A-B", "sad", 3);
            scaleDetails[3] = dorian;
            ScaleClass mminor = new ScaleClass("Melodic Minor", "The melodic minor scale is a sad scale\n that has this as a structure: \nTone-SemiTone\nTone-Tone-Tone-Tone\n For example, \n the notes in the C Major scale are: \n C-D-D#-F-G-A-B", "sad", 4);
            scaleDetails[4] = mminor;
            ScaleClass hminor = new ScaleClass("Harmonic Minor", "The harmonic minor scale is a sad scale\n that has this as a structure: \nTone-Semitone\nTone-Tone-SemiTone-Tone\n For example, \n the notes in the C Major scale are: \n C-D-D#-F-G-G#-B", "sad", 5);
            scaleDetails[5] = hminor;
            ScaleClass lydian = new ScaleClass("Lydian", "The lydian mode is a happy mode\n that has this as a structure: \nTone-Tone-Tone\nSemiTone-Tone-Tone-Tone\n For example, \n the notes in the C Major scale are: \n C-D-E-F#-G-A-B", "happy", 6);
            scaleDetails[6] = lydian;
            ScaleClass mixolydian = new ScaleClass("Mixolydian", "The mixolydian mode is a happy mode\n that has this as a structure: \nTone-Tone-Semitone\nTone-Tone-SemiTone-Tone\n For example, \n the notes in the C Major scale are: \n C-D-E-F-G-A-A#", "happy", 7);
            scaleDetails[7] = mixolydian;

            backButton.Click += BackButton_Click;
            scaleList.ItemClick += ScaleList_ItemClick;


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Intent backIntent = new Intent(this, typeof(MainActivity));
            StartActivity(backIntent);
        }

        void ScaleList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent scaleAct = new Intent(this, typeof(ScaleListActivity));
            ScaleClass selectedScale = scaleDetails[e.Position];
            string seriScale = JsonConvert.SerializeObject(selectedScale);
            scaleAct.PutExtra("scale", seriScale);
            StartActivity(scaleAct);
        }

    }

}