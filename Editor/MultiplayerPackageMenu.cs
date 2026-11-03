using UnityEditor;

namespace Carp.Multiplayer.Editor
{
    public class MultiplayerPackageMenu
    {
        [MenuItem("Carp/Multiplayer/Log Hello")]
        public static void LogHelloMenu()
        {
            Multiplayer.LogHello();
        }
    }
}
