using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] Button settingsBtn;
    [SerializeField] Button startBtn;

    [Space(10)]
    [SerializeField] Text bestScoreText;

    private void Start()
    {
        settingsBtn.onClick.AddListener(() =>
        {
            UIManager.OpenWindow(Window.Settings);
        });

        startBtn.onClick.AddListener(() =>
        {
            Destroy(FindObjectOfType<Menu>().gameObject);
            UIManager.OpenWindow(Window.Game);
        });
    }
}
