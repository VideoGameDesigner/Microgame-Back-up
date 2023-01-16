using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Transform firepoint;
    [SerializeField] GameObject Laserprefab;
    private float firerate = 0.3f;
    private float nextfire = 0f;
    public AudioClip lasersound;
    private AudioSource myaudio;


    // Start is called before the first frame update
    void Start()
    {
        myaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")&& Time.time > nextfire)
        {
            myaudio.PlayOneShot(lasersound);
            nextfire = Time.time + firerate;
            shoot();
        }
    }

    private void shoot()
    {

        Instantiate(Laserprefab, firepoint.position, firepoint.rotation);

    }

        

}
