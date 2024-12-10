using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSharpsNFlats : MonoBehaviour
{
    public Transform aFlatSpawnPos;
    public Transform bFlatSpawnPos;
    public Transform eFlatSpawnPos;
    public Transform fSharpSpawnPos;
    public Transform cSharpSpawnPos;
    public GameObject flat, sharp;
    public float noteSpeed = 2;

    public void Start()
    {
        Rigidbody2D sharpRB = sharp.GetComponent<Rigidbody2D>();
        sharpRB.velocity = Vector2.left * noteSpeed;
        Rigidbody2D flatRB = flat.GetComponent<Rigidbody2D>();
        flatRB.velocity = Vector2.left * noteSpeed;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(sharp, fSharpSpawnPos.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(flat, aFlatSpawnPos.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(flat, bFlatSpawnPos.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(sharp, cSharpSpawnPos.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Instantiate(flat, eFlatSpawnPos.position, Quaternion.identity);
        }
        
    }
}
