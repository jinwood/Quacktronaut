using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector2 velocity;

    private ObstacleSpawner spawner;
    private float spinSpeed;

    void Start ()
    {
        spinSpeed = Random.Range(-15, 15);
        var spawnerObject = GameObject.FindWithTag("GameController");
        spawner = spawnerObject.GetComponent<ObstacleSpawner>();
        GetComponent<Rigidbody2D>().velocity = velocity;
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject); //just incase
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
