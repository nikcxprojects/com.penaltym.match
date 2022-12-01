using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] Button resumeBtn;

    private void Start()
    {
        resumeBtn.onClick.AddListener(() =>
        {
            Destroy(gameObject);
        });
    }
}
