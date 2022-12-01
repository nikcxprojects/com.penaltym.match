using UnityEngine.UI;
using UnityEngine;

public class Balls : MonoBehaviour
{
    [SerializeField] Button backBtn;

    private void Start()
    {
        backBtn.onClick.AddListener(() =>
        {
            Destroy(gameObject);
        });
    }
}
