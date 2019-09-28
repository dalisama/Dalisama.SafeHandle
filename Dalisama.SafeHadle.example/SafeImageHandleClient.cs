using Microsoft.Win32.SafeHandles;
using System;
using System.Drawing;

namespace Dalisama.SafeHadle.example
{
    public class SafeImageHandleClient : IDisposable
    {
        private SafeImageHandle _safeHandle;
        private SafeImageHandle _safeHandleCopy;
        bool disposed = false;
        public SafeImageHandleClient(IntPtr handle)
        {
            _safeHandle =new SafeImageHandle(handle);
        }
        public SafeImageHandleClient(string path)
        {
            Bitmap myBitmap = new Bitmap(path);
            _safeHandle = new SafeImageHandle(myBitmap.GetHbitmap());
           
        }

        public void CopyImageAndDoSth()
        {
            _safeHandleCopy =SafeImageHandleApi.CopyImage(_safeHandle, 0, 0, 0, 0x00000001);
            DoStuff();
        }
        void DoStuff()
        {

        }
        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.    
            }
            // Free any unmanaged objects here.
            _safeHandle.Dispose();
            _safeHandleCopy.Dispose();
            disposed = true;
        }

      
    }
}
