using System.Collections.Generic;
using UnityEngine;

namespace TestMod
{
    internal class Test
    {
        public static string GetGameObjectPath(Transform transform)
        {
            List<string> path = new List<string>();

            while (transform != null)
            {
                path.Insert(0, transform.name);
                transform = transform.parent;
            }

            return string.Join("/", path);
        }
    }
}
