using System;
using System.Runtime.InteropServices;

namespace Dalisama.SafeHadle.example
{
    public static class SafeImageHandleApi
    {

        [DllImport("User32.dll")]
        public static extern SafeImageHandle CopyImage(SafeImageHandle h, int type, int cx, int cy, int flags);

        [DllImport("Gdi32.dll", CharSet = CharSet.Auto)]
       public extern static bool DeleteObject(SafeImageHandle handle);
    }
}
