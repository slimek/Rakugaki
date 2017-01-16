using UnityEditor;
using UnityEditor.SceneManagement;

//
// Switch Scenes and Views from Menu
//
public static class ScenesMenu
{
    [MenuItem("Scenes/Start Scene", false, 0)]
    public static void Start()
    {
        OpenScene("Start");
    }

    [MenuItem("Scenes/Title View", false, 1)]
    public static void Title()
    {
        OpenView("Title");
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
            EditorSceneManager.OpenScene(scenePath);
        }
    }

    private static void OpenView(string viewName)
    {
        var viewPath = string.Format("Assets/Views/{0}.unity", viewName);

        if (EditorSceneManager.GetActiveScene().path == viewPath)
        {
            EditorUtility.DisplayDialog(
                "Hint",
                string.Format("{0} view is already open", viewName),
                "Ok"
            );
            return;
        }

        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
        {
            EditorSceneManager.OpenScene(viewPath);
        }
    }
}
