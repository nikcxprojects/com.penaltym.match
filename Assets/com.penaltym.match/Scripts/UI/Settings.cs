using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] Button backBtn;
    [SerializeField] Button ballsBtn;

    private void Start()
    {
        backBtn.onClick.AddListener(() =>
        {
            Destroy(gameObject);
        });

        ballsBtn.onClick.AddListener(() =>
        {
            UIManager.OpenWindow(Window.Balls);
        });
    }
}
