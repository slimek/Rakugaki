using UnityEditor;
using UnityEditor.SceneManagement;

//
// Switch Scenes and Views from Menu
//
public static class ScenesMenu
{
    public static void Start()
    {
    }

    private static void OpenScene(string sceneName)
    {
        var scenePath = string.Format("Assets/Scenes/{0}.unity", sceneName);

        if (EditorSceneManager.GetActiveScene().path == scenePath)
        {
            EditorUtility.DisplayDialog(
                "Hint",
                string.Format("{0} scene is already open", sceneName),
                "Ok"
            );
            return;
        }

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
        }
    }
}
