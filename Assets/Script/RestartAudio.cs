using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartAudio : MonoBehaviour
{
    public AudioSource restartSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        restartSound.Play();
    }
}
