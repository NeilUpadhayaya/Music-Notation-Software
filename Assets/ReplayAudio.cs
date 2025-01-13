using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayAudio : MonoBehaviour
{
    public AudioSource replaySound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        replaySound.Play();
        
    }

}
