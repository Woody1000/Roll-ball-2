using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    public GameObject obstaclesDestrPoint;
    void Start()
    {
        obstaclesDestrPoint = GameObject.Find("ObsDestrPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < obstaclesDestrPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
