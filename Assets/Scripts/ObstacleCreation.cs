using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreation : MonoBehaviour
{
    public float timer;
    Random rand = new Random();
    public float timeRange;
    public GameObject generationPoint_1;
    public GameObject generationPoint_2;
    public GameObject prefabObstacle;

    private GameObject _obstacles;
    
    void Start()
    {
        SpawnObstacles();
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
    }


    public void SpawnObstacles()
    {
        _obstacles = Instantiate(prefabObstacle, transform);
        Vector3 positionObs = new Vector3(Random.Range(generationPoint_1.transform.localPosition.x, generationPoint_2.transform.localPosition.x), generationPoint_1.transform.localPosition.y, 0);
        _obstacles.transform.localPosition = positionObs;

    }

    public void ResetTimerAndSpawn()
    {
        if (timer > timeRange)
        {
            SpawnObstacles();
            timer = 0;
        }
    }

}
