using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupScreen : MonoBehaviour
{
    public GameObject startScreen;
    private bool canFade;
    private Color alphaColor;
    private float fadeTime = 2.0f;
    void Start()
    {
        canFade = true;
        alphaColor = startScreen.GetComponent<SpriteRenderer>().material.color;
        alphaColor.a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (canFade)
        {
            startScreen.GetComponent<SpriteRenderer>().material.color = Color.Lerp(startScreen.GetComponent<SpriteRenderer>().material.color, alphaColor, fadeTime * Time.deltaTime);
        }
    }
}
