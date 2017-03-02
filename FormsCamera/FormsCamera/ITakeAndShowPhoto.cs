using Android.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCamera
{
    public interface ITakeAndShowPhoto
    {
        void TakePhoto();

        Bitmap LoadPhoto();

        string PhotoPath();
    }
}