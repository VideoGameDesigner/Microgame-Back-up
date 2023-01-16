using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawn : MonoBehaviour
{
    [SerializeField] GameObject enemymaker;
    public float timetospawn;
    private float curenttimetospawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(curenttimetospawn > 0)
        {
            curenttimetospawn -= Time.deltaTime;            
        }

        else
        {          
            spawn();
            curenttimetospawn = timetospawn;
        }
            
    }

    public void spawn()
    {
                
      Vector3 enemyposition = new Vector3(Random.Range(-5, 5), 9f, 0f);
      Instantiate(enemymaker, enemyposition, enemymaker.transform.rotation);
                        
    }
}
