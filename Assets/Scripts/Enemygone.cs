using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemygone : MonoBehaviour
{
    public static float enemyspeed = 7f;
    public GameObject explosioneffect;
    private Transform target;
    
    


    // Start is called before the first frame update
    void Start()
    {
        
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, enemyspeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            
            Instantiate(explosioneffect, transform.position, Quaternion.identity);
            GameControl.enemyspeedplus -= 1;
            GameControl.playerscore += 1;
            Destroy(other.gameObject);

        }
    }

    private void LateUpdate()
    {
        if (transform.position.y <= -11)
        {

            Destroy(gameObject);
        }
    }




}
