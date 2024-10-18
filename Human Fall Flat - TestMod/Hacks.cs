using System;
using UnityEngine;

namespace TestMod
{
    internal class Hacks : MonoBehaviour
    {
        private Vector2 scrollPosition;
        private bool showMenu = true;
        private Rect windowRect = new Rect(100, 100, 300, 200);

        private bool isDragging = false;
        private Vector2 dragOffset;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Insert))
            {
                showMenu = !showMenu;
            }
        }
        private string GetGameObjectPath(GameObject obj)
        {
            string path = obj.name;
            Transform current = obj.transform;

            // Traverse the hierarchy upwards to build the path.
            while (current.parent != null)
            {
                current = current.parent;
                path = current.name + "/" + path;
            }

            return path;
        }
        void OnGUI()
        {
            if (showMenu)
            {
                scrollPosition = GUILayout.BeginScrollView(scrollPosition, GUILayout.Width(300), GUILayout.Height(400));

                // Fetch all active game objects in the scene.
                GameObject[] allObjects = FindObjectsOfType<GameObject>();

                // Display each game object.
                foreach (GameObject obj in allObjects)
                {
                    string objectPath = Test.GetGameObjectPath(obj.transform);
                    // Display the object's name.
                    if (GUILayout.Button(objectPath))
                    {
                        GameObject.Find(objectPath).SetActive(false);
                        Console.WriteLine(objectPath + " Disabled");
                    }
                }

                // End the scroll view.
                GUILayout.EndScrollView();
            }
        }
    }
}