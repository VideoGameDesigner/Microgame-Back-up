using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float MovementSpeed = 1;

    private float movement;
    private Rigidbody2D rb;
    public static bool loser;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -4.85f, 4.85f), transform.position.y);
    }

    private void FixedUpdate()
    {
        playermovement();
    }

    private void playermovement()

    {
        movement = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movement * MovementSpeed, rb.velocity.y);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            loser = true;
            GameControl.winner = false;
            GameControl.totalscore = GameControl.playerscore;
            Enemygone.enemyspeed = 7f;
            SceneManager.LoadScene("GameOver");
        }
    }
}
