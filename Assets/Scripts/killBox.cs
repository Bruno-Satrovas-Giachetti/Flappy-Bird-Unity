using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBox : MonoBehaviour
{
    private AudioSource audioSource;
    public GameManager gameBehavior;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();
        gameBehavior.GameOver();
        //print("Hoje é dia de lixo. RETIRE-SE.");
    }
}
