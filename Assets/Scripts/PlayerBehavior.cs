using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float jumpForce = 700;
    public bool canFly;

    [SerializeField] private AudioClip[] audioClip;
    private AudioSource audioSource;


    void Awake()
    {
       rigidbody = GetComponent<Rigidbody2D>();
       audioSource = GetComponent<AudioSource>();
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
        audioSource.clip = audioClip[0];
        audioSource.Play();
        canFly = false;
    }

}
