using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Hoje � dia de lixo. RETIRE-SE.");
    }
}
