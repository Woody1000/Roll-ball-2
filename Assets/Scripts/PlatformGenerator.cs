using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;
    public float timer;
    public float timeRange;
    public int numberWhenCreate;
    public GameObject prefabObstacle;

    Random rand = new Random();

    private float _platformWidth;
    void Start()
    {
        _platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if(transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + _platformWidth + distanceBetween, transform.position.y, transform.position.z);

            Instantiate(thePlatform, transform.position, transform.rotation);
        }

        CreateObstacle();

        
    }

    public void CreateObstacle()
    {
        if(timer > timeRange)
        {
            
            timer = 0;
            if (timer == 0)
            {
                numberWhenCreate = Random.Range(1, 4);
            }

            
        }

        if (numberWhenCreate == 2)
        {
            transform.position = new Vector3(thePlatform.transform.position.x, thePlatform.transform.position.y + 1, thePlatform.transform.position.z);
            Instantiate(prefabObstacle, transform.position, transform.rotation);
        }
    }
}
