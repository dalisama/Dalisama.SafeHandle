using Dalisama.SafeHadle.example;
using System;
class Program
{


    static void Main()
    {

        #region Using handle without safe Handle
        using (var client = new ImageHandleClient("bat.jpg"))
        {
            client.CopyImageAndDoSth();
        }
        #endregion

        #region Using handle without safe Handle
        using (var client = new SafeImageHandleClient("bat.jpg"))
        {
            client.CopyImageAndDoSth();
        }
        #endregion
        Console.ReadLine();

    }
}