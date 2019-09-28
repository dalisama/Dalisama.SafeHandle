using System;
using System.Runtime.InteropServices;

namespace Dalisama.SafeHadle.example
{
    public static class ImageHandleApi
    {

        [DllImport("User32.dll")]
        public static extern IntPtr CopyImage(IntPtr h, int type, int cx, int cy, int flags);

        [DllImport("Gdi32.dll", CharSet = CharSet.Auto)]
       public extern static bool DeleteObject(IntPtr handle);
    }
}
