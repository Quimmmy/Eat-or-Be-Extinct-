using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.Play(); // plays music at start
    }
}
