using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnLocation : MonoBehaviour
{
    public GameObject enemyPrefab;
    float time = 0;
    PlayerMovement player;
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>2.0f && player!=null )
        {
            float value = Random.Range(-2.0f, 2.0f);
            GameObject enemyref = Instantiate(enemyPrefab);
            enemyref.transform.position = new Vector3(value, 6.0f, 0);
            time = 0;
        }
        
    }
}
