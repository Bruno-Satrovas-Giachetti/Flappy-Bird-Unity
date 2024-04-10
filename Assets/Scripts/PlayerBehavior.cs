using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    Rigidbody2D rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rigidbody.AddForce(new Vector2(0, 700));            
        }
    }
}
