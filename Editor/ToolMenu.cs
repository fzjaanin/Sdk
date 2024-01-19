using UnityEditor;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace dinomite
{
    public static class ToolMenu
    {
        [MenuItem("Dinomite/Setup/Creat Default Folders")]
        public static void CreateDefaultFolders()
        {
            CreateDirectories("Project", "Animations", "Audio", "Models", "Materials", "Prefabs", "Resources", "Scenes", "Scripts", "StreamingAssets", "SandBox", "ThirdParty", "UI");
            Refresh();
        }

        public static void CreateDirectories(string root, params string[] dir)
        {
            var fullpath = Combine(dataPath, root);
            foreach (var newDirectory in dir)
                CreateDirectory(Combine(fullpath, newDirectory));
        }
    }
}

