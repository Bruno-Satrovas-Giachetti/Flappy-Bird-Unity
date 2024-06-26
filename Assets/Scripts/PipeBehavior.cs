using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PipeBehavior : MonoBehaviour
{
    private AudioSource audioSource;

    public float speed;
    public float minPositionX = -6.32f;
    public float spawnPositionX = 2.2f;
    public float minPositionsY = -2.23f;
    public float maxPositionY = 1.94f;

    int score = 0;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //some -6.32
    //surge 2.2
    //yMax 1.94
    //yMin -2.23

    void Start()
    {
        Vector2 newPosition = new Vector2(spawnPositionX, SetRandomYPosition());
        transform.position = newPosition;
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime );
        if (transform.position.x < minPositionX)
        {
                Vector2 newPosition = new Vector2(spawnPositionX, SetRandomYPosition());
                transform.position = newPosition;
        }
    }

    private float SetRandomYPosition()
    {
        return Random.Range(minPositionsY, maxPositionY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.Play();
        score++;
        GameManager.gameBehavior.uiManager.UpdateScoreUI(score);
        print("Pontua��o: " + score);
    }
}
