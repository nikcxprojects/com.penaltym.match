using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] AudioSource sfxSource;

    private void Awake()
    {
        Player.OnCollided += () =>
        {
            if (sfxSource.isPlaying)
            {
                sfxSource.Stop();
            }

            sfxSource.Play();
        };
    }
}
