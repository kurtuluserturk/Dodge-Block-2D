using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;
    float mapWidth = 3.5f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, +mapWidth);
        rb.MovePosition(newPosition);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        FindObjectOfType<GameManager>().EndGame();                  
    }
}
