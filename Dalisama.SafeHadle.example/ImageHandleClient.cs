using System;
using System.Drawing;

namespace Dalisama.SafeHadle.example
{
    public class ImageHandleClient : IDisposable
    {
        private IntPtr _handle;
        private IntPtr _handleCopy;
        bool disposed = false;
        public ImageHandleClient(IntPtr handle)
        {
            _handle = handle;
        }
        public ImageHandleClient(string path)
        {
            Bitmap myBitmap = new Bitmap(path);
            _handle = myBitmap.GetHbitmap();
        }

        public void CopyImageAndDoSth()
        {
            _handleCopy = ImageHandleApi.CopyImage(_handle, 0, 0, 0, 0x00000001);
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
            ImageHandleApi.DeleteObject(_handle);
            ImageHandleApi.DeleteObject(_handleCopy);
            disposed = true;
        }

        ~ImageHandleClient()
        {
            Dispose(false);
        }
    }
}
