using UnityEngine.UI;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public static string BallKey { get => "ball"; }

    [SerializeField] Button backBtn;

    [Space(10)]
    [SerializeField] Transform balls;
    [SerializeField] Transform hover;

    private void Start()
    {
        backBtn.onClick.AddListener(() =>
        {
            Destroy(gameObject);
        });

        foreach (Transform ball in balls)
        {
            ball.GetComponent<Button>().onClick.AddListener(() =>
            {
                PlayerPrefs.SetInt(BallKey, ball.GetSiblingIndex());
            });
        }
    }
}
