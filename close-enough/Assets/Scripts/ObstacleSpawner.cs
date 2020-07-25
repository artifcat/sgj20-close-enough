using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject[] obstacles;
    public float deathTime = 15;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject obs = Instantiate(obstacles[Random.Range(0, obstacles.Length)]);
            obs.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(obs, deathTime);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
