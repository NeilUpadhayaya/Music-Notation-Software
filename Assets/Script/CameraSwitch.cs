using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject destroyTrigger;
    public GameObject eSpawner, fSpawner, gSpawner, aSpawner, bSpawner, cSpawner, dSpawner, hieSpawner;
    public GameObject aFlat,bFlat,cSharp,eFlat,fSharp;
    public GameObject replaySound;
    
    // Start is called before the first frame update
    void Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        destroyTrigger.gameObject.SetActive(false);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        CameraTwo();
        destroyTrigger.gameObject.SetActive(true);
        cSpawner.gameObject.SetActive(false);
        dSpawner.gameObject.SetActive(false);
        eSpawner.gameObject.SetActive(false);
        fSpawner.gameObject.SetActive(false);
        gSpawner.gameObject.SetActive(false);
        aSpawner.gameObject.SetActive(false);
        bSpawner.gameObject.SetActive(false);
        hieSpawner.gameObject.SetActive(false);
        aFlat.SetActive(false);
        bFlat.SetActive(false);
        cSharp.SetActive(false);
        eFlat.SetActive(false);
        fSharp.SetActive(false);
        replaySound.SetActive(false);

    }

    void Update()
    { 

    }

    void CameraOne()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }
    void CameraTwo()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
    }
   



}
