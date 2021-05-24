using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletMovement : MonoBehaviour
{
    Rigidbody2D bulletRB;
    AudioSource enemyDestroySound;
    public AudioClip enemyClip;
    //public int score;
    ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        scoreManager = FindObjectOfType <ScoreManager>();
        enemyDestroySound = GameObject.Find("SoundManager").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        bulletRB.velocity = new Vector2(0, 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            enemyDestroySound.clip = enemyClip;
            enemyDestroySound.Play();
            scoreManager.IncrementScore();
        }
    }
}
