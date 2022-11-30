using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    [Space(10)]
    [SerializeField] AudioSource music;

    [Space(10)]
    [SerializeField] AudioSource sound;

    private const string activeSwither = "#245407";
    private const string activeHandler = "#245407";

    private const string disableSwither = "#414141";
    private const string disableHandler = "#414141";

    private void Start()
    {
        
    }
}
