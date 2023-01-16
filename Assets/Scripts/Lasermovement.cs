using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasermovement : MonoBehaviour
{

    [SerializeField] float laserspeed = 20f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * laserspeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))

        {
            
            Destroy(other.gameObject);
        }
        
        
    }

    private void LateUpdate()
    {
        if(transform.position.y >= 10)
        {

            Destroy(gameObject);
        }
    }


}
