
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
using Android.Media;

namespace MyLittleModeBook
{
    [Activity(Label = "MediaPlay")]
    public class MediaPlay : Activity
    {
        MediaPlayer scalePlayer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MediaPlay);
            TextView title = (TextView)FindViewById(Resource.Id.titleMedia);
            string mediaScale = Intent.GetStringExtra("media");
            ImageView playImage = (ImageView)FindViewById<ImageView>(Resource.Id.isPlay);
            title.Text = mediaScale;
            Button playAudio = (Button)FindViewById<Button>(Resource.Id.playButton);
            Button backToMedia = (Button)FindViewById<Button>(Resource.Id.backToMediaListButton);
            playImage.SetImageResource(Resource.Drawable.playing);
            if (mediaScale == "C Major")
            {
                scalePlayer = MediaPlayer.Create(this, Resource.Raw.major);
            }
            else if (mediaScale == "C Minor")
            {
                scalePlayer = MediaPlayer.Create(this, Resource.Raw.minor);

            }
            else if (mediaScale == "C Minor Pentatonic")
            {
                scalePlayer = MediaPlayer.Create(this, Resource.Raw.pentatonic);
            }
            else if (mediaScale == "C Dorian")
            {
                scalePlayer = MediaPlayer.Create(this, Resource.Raw.dorian);
            }
            else if (mediaScale == "C Melodic Minor")
            {
                scalePlayer = MediaPlayer.Create(this, Resource.Raw.mminor);
            }
            else if (mediaScale == "C Lydian")
            {
                scalePlayer = MediaPlayer.Create(this, Resource.Raw.lydian);
            }
            else if (mediaScale == "C Mixolydian")
            {
                scalePlayer = MediaPlayer.Create(this, Resource.Raw.mixolydian);
            }
            else if (mediaScale == "C Harmonic Minor")
            {
                scalePlayer = MediaPlayer.Create(this, Resource.Raw.hminor);
            }
            playAudio.Click += PlayAudio_Click; 
            backToMedia.Click += BackToMedia_Click;
           



        }

        void PlayAudio_Click(object sender, EventArgs e)
        {
            scalePlayer.Start();
        }

        void BackToMedia_Click(object sender, EventArgs e)
        {
            Intent backList = new Intent(this, typeof(Main3Actiity));
            StartActivity(backList);
        }

    }
}
