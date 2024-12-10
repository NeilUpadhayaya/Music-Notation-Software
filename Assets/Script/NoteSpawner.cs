using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public NoteObject noteE, noteF, noteFSharp, noteG, noteAFlat, noteA, noteBFlat, noteB, noteC, noteCSharp, noteD, noteEFlat, noteHiE;
    public Transform restSpawnPos;
    public Transform backgroundSpawnPos;
    public GameObject backGround1;
    public GameObject backGround2;

    public Dictionary<KeyCode, NoteObject> notes = new Dictionary<KeyCode, NoteObject>();


    [SerializeField] GameObject sixteenthRest, eighthRest, quarterRest, halfRest, wholeRest;
    

    [SerializeField] GameObject wholeNote, halfNote, quarterNote, eighthNote, sixteenthNote;

    [SerializeField] float wholeTime, halfTime, quarterTime, eighthTime, sixteenthTime;

    [SerializeField] float wholeRestTime, halfRestTime, quarterRestTime, eighthRestTime, sixteenthRestTime;

    KeyCode[] keyCodes = { (KeyCode.Z), (KeyCode.X), (KeyCode.C), (KeyCode.V), (KeyCode.B), (KeyCode.N), (KeyCode.M), (KeyCode.Comma), (KeyCode.A), (KeyCode.S), (KeyCode.D), (KeyCode.F), (KeyCode.G) };

    public float noteSpeed, restTime, backgroundTime;

    public bool keyResting, backgroundSpawning;
    public float spawnTime;
    public float spawnDelay;

    private void Start()
    {

        StartCoroutine(BackgroundWait());
        
        backgroundSpawning = false;
        InvokeRepeating("SpawnBackground", spawnTime, spawnDelay);
        notes.Add(KeyCode.Z, noteE);
        notes.Add(KeyCode.X, noteF);
        notes.Add(KeyCode.C, noteG);
        notes.Add(KeyCode.V, noteA);
        notes.Add(KeyCode.B, noteB);
        notes.Add(KeyCode.N, noteC);
        notes.Add(KeyCode.M, noteD);
        notes.Add(KeyCode.Comma, noteHiE);
        notes.Add(KeyCode.A, noteFSharp);
        notes.Add(KeyCode.S, noteAFlat);
        notes.Add(KeyCode.D, noteBFlat);
        notes.Add(KeyCode.F, noteCSharp);
        notes.Add(KeyCode.G, noteEFlat);
    }
    private void Update()
    {
        
        keyResting = true;
        
        foreach (KeyCode selectedKeyCode in keyCodes)
        {
            if (Input.GetKeyDown(selectedKeyCode))
            {
                notes[selectedKeyCode].timePressed = 0;
                keyResting = false;
                
            }
            if (Input.GetKey(selectedKeyCode))
            {
                notes[selectedKeyCode].timePressed += Time.deltaTime;
                keyResting = false;
            }
            if (Input.GetKeyUp(selectedKeyCode))
            {
                SpawnKey(notes[selectedKeyCode]);
                notes[selectedKeyCode].noteSource.Stop();
            }
           
        }
        if (keyResting)
        {
            restTime += Time.deltaTime;
        }
        else
        {
            restTime = 0;
        }

        if(restTime >= 4)
        {
            SpawnRest();
            restTime = 0;
        }


    }

    void SpawnKey(NoteObject note)
    {
        GameObject spawnedNote;

        if (note.timePressed <= sixteenthTime)
        {
            spawnedNote = Instantiate(sixteenthNote, note.spawnPos.position, Quaternion.identity);
        }
        else if (note.timePressed <= eighthTime)
        {
            spawnedNote = Instantiate(eighthNote, note.spawnPos.position, Quaternion.identity);
        }
        else if (note.timePressed <= quarterTime)
        {
            spawnedNote = Instantiate(quarterNote, note.spawnPos.position, Quaternion.identity);
        }
        else if (note.timePressed <= halfTime)
        {
            spawnedNote = Instantiate(halfNote, note.spawnPos.position, Quaternion.identity);
        }
        else
        {
            spawnedNote = Instantiate(wholeNote, note.spawnPos.position, Quaternion.identity);
        }

        Rigidbody2D noteRB = spawnedNote.GetComponent<Rigidbody2D>();
        noteRB.velocity = Vector2.left * noteSpeed;
    }
    public void SpawnRest()
    {
        GameObject spawnedRest;

        if (restTime <= sixteenthRestTime)
        {
            spawnedRest = Instantiate(sixteenthRest, restSpawnPos.position, Quaternion.identity);
        }
        else if (restTime <= eighthTime)
        {
            spawnedRest = Instantiate(eighthRest, restSpawnPos.position, Quaternion.identity);
        }
        else if (restTime <= quarterTime)
        {
            spawnedRest = Instantiate(quarterRest, restSpawnPos.position, Quaternion.identity);
        }
        else if (restTime <= halfTime)
        {
            spawnedRest = Instantiate(halfRest, restSpawnPos.position, Quaternion.identity);
        }
        else
        {
            spawnedRest = Instantiate(wholeRest, restSpawnPos.position, Quaternion.identity);
        }
        Rigidbody2D restRB = spawnedRest.GetComponent<Rigidbody2D>();
        restRB.velocity = Vector2.left * noteSpeed;

        spawnedRest.transform.position += new Vector3(-restTime, 0, 0);
    }
    
    public void SpawnBackground()
    {
        GameObject spawnedBackground;

       spawnedBackground= Instantiate(backGround2, backgroundSpawnPos.position, Quaternion.identity);
        Rigidbody2D backgroundRB = spawnedBackground.GetComponent<Rigidbody2D>();
        backgroundRB.velocity = Vector2.left * noteSpeed;
        if (backgroundSpawning)
        {
            CancelInvoke("SpawnBackground");
        }

    }
    IEnumerator BackgroundWait()
    {
        yield return new WaitForSeconds(4);
        Rigidbody2D initalBackgroundRB = backGround1.GetComponent<Rigidbody2D>();
        initalBackgroundRB.velocity = Vector2.left * noteSpeed;


    }

    [Serializable]
    public class NoteObject
    {
        public Transform spawnPos;
        public float timePressed;
        public AudioSource noteSource;
    }
}
