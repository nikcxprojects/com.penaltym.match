using UnityEngine;

public static class WindowUtility
{
    public static void TryGetWindow(string window, out GameObject refWindow)
    {
        refWindow = Resources.Load<GameObject>($"UI/{window}");
    }
}
