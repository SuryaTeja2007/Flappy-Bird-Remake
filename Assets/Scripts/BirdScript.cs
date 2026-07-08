using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength = 20;
    public LogicScript logic;
    public bool isBridAlive = true;

    void Start()
    {
        rb.gravityScale = 3;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isBridAlive)
        {
            rb.linearVelocity = Vector2.up * flapStrength;
        }

        if(transform.position.y > 17 || transform.position.y < -15)
        {
            logic.gameOver();
            isBridAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isBridAlive = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("GoldPipe"))
        {
            logic.addScore(5);
        }
        else if (collision.CompareTag("NormalPipe"))
        {
            logic.addScore(1);
        }
    }
}
