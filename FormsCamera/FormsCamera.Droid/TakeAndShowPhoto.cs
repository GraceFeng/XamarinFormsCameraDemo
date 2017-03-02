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
using FormsCamera.Droid;
using Xamarin.Forms;
using Android.Provider;
using Android.Graphics;
using Java.IO;
using Android.Content.PM;
using System.Threading.Tasks;

[assembly: Dependency(typeof(TakeAndShowPhoto))]

namespace FormsCamera.Droid
{
    public class TakeAndShowPhoto : ITakeAndShowPhoto
    {
        public void TakePhoto()
        {
            CreateDirectoryForPictures();

            Intent intent = new Intent(MediaStore.ActionImageCapture);
            MainActivity._file = new File(MainActivity._dir, String.Format("myPhoto_{0}.png", Guid.NewGuid()));
            intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(MainActivity._file));
            var activity = Forms.Context as Activity;
            activity.StartActivityForResult(intent, 0);
        }

        public Bitmap LoadPhoto()
        {
            if (MainActivity.bitmap != null)
            {
                return MainActivity.bitmap;
            }
            else
                return null;
        }

        public string PhotoPath()
        {
            if (MainActivity._file != null)
            {
                return MainActivity._file.Path;
            }
            else
                return null;
        }

        private void CreateDirectoryForPictures()
        {
            MainActivity._dir = new File(
                Android.OS.Environment.GetExternalStoragePublicDirectory(
                    Android.OS.Environment.DirectoryPictures), "CameraAppDemo");
            if (!MainActivity._dir.Exists())
            {
                MainActivity._dir.Mkdirs();
            }
        }
    }
}