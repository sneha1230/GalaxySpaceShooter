using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject Bulletobj;
    AudioSource bulletaudio;
    public AudioClip bulletsound;
    //public float bulletspeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        bulletaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bulletref = Instantiate(Bulletobj);
            bulletref.transform.position = transform.position+new Vector3(0,0.55f,0);
            bulletaudio.clip = bulletsound;
            bulletaudio.Play();
        }
    }
}
