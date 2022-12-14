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

        hover.transform.position = balls.GetChild(PlayerPrefs.GetInt(BallKey)).position;

        foreach (Transform ball in balls)
        {
            ball.GetComponent<Button>().onClick.AddListener(() =>
            {
                hover.position = ball.position;

                PlayerPrefs.SetInt(BallKey, ball.GetSiblingIndex());
                PlayerPrefs.Save();

                FindObjectOfType<Menu>()?.UpdateMenuBall();
            });
        }
    }
}
