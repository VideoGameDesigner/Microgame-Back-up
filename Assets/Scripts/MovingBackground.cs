using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    public float scrollSpeed = -5f;
    Vector2 startpos;
    float newpos;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newpos = Mathf.Repeat(Time.time * scrollSpeed, 60f);
        transform.position = startpos + Vector2.up * newpos;
    }
}
