using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundGen : MonoBehaviour
{
    public AudioSource eSource, fSource, fSharpSource, gSource, aFlatSource, aSource, bFlatSource, bSource, cSource, cSharpSource, dSource, eFlatSource, hieSource;
    public GameObject eNoteObj, fNoteObj, fSharpObj, gNoteObj, aFlatObj, aNoteObj, bFlatObj, bNoteObj, cNoteObj, cSharpObj, dNoteObj, eFlatObj, hieNoteObj, restNoteObj;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            eSource.Play();
        } 
           
        if (Input.GetKeyUp(KeyCode.Z))
        {
           eSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            fSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            fSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            gSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            gSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            aSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.V))
        {
            aSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            bSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            bSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            cSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.N))
        {
            cSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            dSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.M))
        {
            dSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            hieSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.Comma))
        {
            
            hieSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            fSharpSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {

            fSharpSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            aFlatSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.S))
        {

            aFlatSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            bFlatSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {

            bFlatSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            cSharpSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.F))
        {

            cSharpSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            eFlatSource.Play();
        }

        if (Input.GetKeyUp(KeyCode.G))
        {

            eFlatSource.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cNoteObj.SetActive(false);
        dNoteObj.SetActive(false);
        eNoteObj.SetActive(false);
        fNoteObj.SetActive(false);
        gNoteObj.SetActive(false);
        aNoteObj.SetActive(false);
        bNoteObj.SetActive(false);
        hieNoteObj.SetActive(false);
        fSharpObj.SetActive(false);
        eFlatObj.SetActive(false);
        aFlatObj.SetActive(false);
        bFlatObj.SetActive(false);
        cSharpObj.SetActive(false);
        restNoteObj.SetActive(false);
    }

}

