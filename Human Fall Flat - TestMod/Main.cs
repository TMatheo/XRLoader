using System;
using TestMod;
using UnityEngine;

namespace Loader
{
    internal class Main
    {
        static GameObject menu;
        public static void XRModOnLoad()
        {
            Console.WriteLine("Loaded test mod");
            menu = new GameObject();
            menu.AddComponent<Hacks>();
            UnityEngine.Object.DontDestroyOnLoad(menu);
        }
    }
}