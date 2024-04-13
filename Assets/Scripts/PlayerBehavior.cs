using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    Rigidbody2D rigidbody;
    
    public float jumpForce = 700;
    public bool canFly;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        canFly = true;
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canFly)
        {
            rigidbody.AddForce(new Vector2(0,jumpForce));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canFly = false;
    }

}
