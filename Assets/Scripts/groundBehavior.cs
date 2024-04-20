using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundBehavior : MonoBehaviour
{
    public float speed;
    public float minPositionX = -6.32f;
    public float spawnPositionX = 2.2f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < minPositionX)
        {
            Vector2 newPosition = new Vector2(spawnPositionX, transform.position.y);
            transform.position = newPosition;
        }
    }
}
