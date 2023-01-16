using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public float distancetocover;
    public float speed;
    private Vector2 startingposition;

    // Start is called before the first frame update
    void Start()
    {
        startingposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = startingposition;
        v.x += distancetocover * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
