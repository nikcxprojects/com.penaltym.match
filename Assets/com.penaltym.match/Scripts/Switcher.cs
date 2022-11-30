using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Switcher : MonoBehaviour
{
    private const float swithDuration = 0.1f;

    private bool Enable { get; set; }
    private Button Button { get; set; }

    private Image Image { get; set; }
    private Image Handler { get; set; }

    private float et = 0.0f;
    private float xMin, xMax;

    private Color activeColorSwithcer;
    private Color activeColorHandler;

    private Color disableColorSwithcer;
    private Color disableColorHandler;

    private const string activeSwither = "#245407";
    private const string activeHandler = "#245407";

    private const string disableSwither = "#414141";
    private const string disableHandler = "#414141";

    [SerializeField] AudioSource targetSource;

    private void Awake()
    {
        Image = GetComponent<Image>();
        Handler = transform.GetChild(0).GetComponent<Image>();

        Button = GetComponent<Button>();

        ColorUtility.TryParseHtmlString(activeSwither, out activeColorSwithcer);
        ColorUtility.TryParseHtmlString(activeHandler, out activeColorHandler);

        ColorUtility.TryParseHtmlString(disableSwither, out disableColorSwithcer);
        ColorUtility.TryParseHtmlString(disableHandler, out disableColorHandler);
    }

    private void Start()
    {
        xMin = -((Image.rectTransform.rect.width - Handler.rectTransform.rect.width) / 2);
        xMax = (Image.rectTransform.rect.width - Handler.rectTransform.rect.width) / 2;

        Button.onClick.AddListener(() =>
        {
            if(et > 0)
            {
                return;
            }

            StartCoroutine(nameof(Switch));
        });
    }

    private IEnumerator Switch()
    {
        Enable = !Enable;
        targetSource.mute = !Enable;

        Image.color = Enable ? activeColorSwithcer : disableColorSwithcer;
        Handler.color = Enable ? activeColorHandler : disableColorHandler;

        float xTarget = Enable ? xMax : xMin;

        Vector2 v2Current = Handler.transform.localPosition;
        Vector2 v2Target = new Vector2(xTarget, v2Current.y);

        while(et < swithDuration)
        {
            Handler.transform.localPosition = Vector2.Lerp(v2Current, v2Target, et / swithDuration);

            et += Time.deltaTime;
            yield return null;
        }

        et = 0;
    }
}
