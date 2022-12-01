using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    [SerializeField] Button resumeBtn;

    private void Start()
    {
        Ball.Sleep();
        resumeBtn.onClick.AddListener(() =>
        {
            Ball.WakeUp();
            Destroy(gameObject);
        });
    }
}
