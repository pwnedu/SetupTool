using UnityEngine;
using UnityEditor;
using System.IO;

namespace pwnedu
{
    public static class ToolsMenu
    {
        [MenuItem("Tools/Project Setup/Create Project Folders")]
        public static void CreateProjectFolders()
        {
            CreateDirectories("_Project", "Models", "Materials", "Prefabs", "Scripts", "Scenes", "Shaders", "Textures");
            AssetDatabase.Refresh();
        }

        [MenuItem("Tools/Project Setup/Create Tool Folders")]
        public static void CreateToolFolders()
        {
            CreateDirectories("_Tools", "MyNotes");
            AssetDatabase.Refresh();
        }

        public static void CreateDirectories(string root, params string[] dir)
        {
            var fullPath = Path.Combine(Application.dataPath, root);
            foreach (var newDirectory in dir)
            {
                Directory.CreateDirectory(Path.Combine(fullPath, newDirectory));
            }
        }
    }
}