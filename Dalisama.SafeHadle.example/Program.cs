using Dalisama.SafeHadle.example;
using System;
class Program
{


    static void Main()
    {

        #region Using handle/pointer without safe Handle
        using (var client = new ImageHandleClient("bat.jpg"))
        {
            client.CopyImageAndDoSth();
        }
        #endregion

        #region Using handle/pointer with safe Handle
        using (var client = new SafeImageHandleClient("bat.jpg"))
        {
            client.CopyImageAndDoSth();
        }
        #endregion
        Console.ReadLine();

    }
}
