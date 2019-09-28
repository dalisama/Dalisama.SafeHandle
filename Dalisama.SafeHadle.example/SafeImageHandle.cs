using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.ConstrainedExecution;

namespace Dalisama.SafeHadle.example
{
    public class SafeImageHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public SafeImageHandle(IntPtr handle)
        : base(true)
        {
            SetHandle(handle);
        }
        public SafeImageHandle()
       : base(true)
        {
            SetHandle(handle);
        }

        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()
        {
            SafeImageHandleApi.DeleteObject(this);
            return true;
        }
    }
}
