﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace MyUnoPlatformApp.Skia.Tizen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new MyUnoPlatformApp.App());
            host.Run();
        }
    }
}
