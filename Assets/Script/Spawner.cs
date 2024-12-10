using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //[SerializeField] private GameObject[] notePrefabs;
    public float noteSpeed = 1f;
    [SerializeField] private GameObject cNote;
    [SerializeField] private GameObject dNote;
    [SerializeField] private GameObject eNote;
    [SerializeField] private GameObject fNote;
    [SerializeField] private GameObject gNote;
    [SerializeField] private GameObject aNote;
    [SerializeField] private GameObject bNote;
    [SerializeField] private GameObject hicNote;
    /*public float holdNote = 5f;
    float holdTimer;
    private object spawnedNote; */
    private float startTime = 0f;
    private float timer = 0f;
    public float holdTime = 2.0f;
    public bool held = false;

    void Start()
    {
        //holdTimer=holdNote;
    }
    // Update is called once per frame
    void Update()
    {
        {
            // Starts the timer from when the key is pressed
            if (Input.GetKeyDown(KeyCode.Z))
            {
                startTime = Time.time;
                timer = startTime;
            }

            // Adds time onto the timer so long as the key is pressed
            if (Input.GetKey(KeyCode.Z) && held == false)
            {
                timer += Time.deltaTime;

                // Once the timer float has added on the required holdTime, changes the bool (for a single trigger), and calls the function
                if (timer > (startTime + holdTime))
                {
                    held = true;
                    ButtonHeld();
                }
            }

            // For single effects. Remove if not needed
            if (Input.GetKeyUp(KeyCode.Z))
            {
                held = false;
            }
        }
        /* 
        if (Input.GetKey(KeyCode.X))
        {
            Spawnd();
        }
        if (Input.GetKey(KeyCode.C))
        {
            Spawne();
        }
        if (Input.GetKey(KeyCode.V))
        {
            Spawnf();
        }
        if (Input.GetKey(KeyCode.B))
        {
            Spawng();
        }
        if (Input.GetKey(KeyCode.N))
        {
            Spawna();
        }
        if (Input.GetKey(KeyCode.M))
        {
            Spawnb();
        }
        if (Input.GetKey(KeyCode.Comma))
        {
            Spawnhic();
        }*/





    }

     void ButtonHeld()
    {
        Spawnc();
        

    }
    void Spawnc()
    {
        GameObject noteToSpawn = cNote;
        if (cNote == true)
        {
            GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);
            Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
            noteRB.velocity = Vector2.left * noteSpeed;
            
        }
        
    }
    private void Spawnd()
    {
        GameObject noteToSpawn = dNote;
        GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
        noteRB.velocity = Vector2.left * noteSpeed;
    }
    private void Spawne()
    {
        GameObject noteToSpawn = eNote;
        GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
        noteRB.velocity = Vector2.left * noteSpeed;
    }
    private void Spawnf()
    {
        GameObject noteToSpawn = fNote;
        GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
        noteRB.velocity = Vector2.left * noteSpeed;
    }
    private void Spawng()
    {
        GameObject noteToSpawn = gNote;
        GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
        noteRB.velocity = Vector2.left * noteSpeed;
    }
    private void Spawna()
    {
        GameObject noteToSpawn = aNote;
        GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
        noteRB.velocity = Vector2.left * noteSpeed;
    }
    private void Spawnb()
    {
        GameObject noteToSpawn = bNote;
        GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
        noteRB.velocity = Vector2.left * noteSpeed;
    }
    private void Spawnhic()
    {
        GameObject noteToSpawn = hicNote;
        GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);

        Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
        noteRB.velocity = Vector2.left * noteSpeed;
    }

}
