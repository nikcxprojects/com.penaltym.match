using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] Button pauseBtn;
    [SerializeField] Button settingsBtn;

    private void Start()
    {
        pauseBtn.onClick.AddListener(() =>
        {
            UIManager.OpenWindow(Window.Pause);
        });

        settingsBtn.onClick.AddListener(() =>
        {
            UIManager.OpenWindow(Window.Settings);
        });

        Player playerPrefab = Resources.Load<Player>("player");

        Vector2 position = new Vector2(0, -3.42f);
        Quaternion rotation = Quaternion.Euler(Vector3.zero);
        Transform parent = GameObject.Find("Environment").transform;

        Instantiate(playerPrefab, position, rotation, parent);
    }
}
