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
    public GameObject prefabCoin;
    public Vector3 actualPlatPosition; 


    Random rand = new Random();

    private float _platformWidth;
    private int count = 0;
    private int count_2 = 0;

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
            actualPlatPosition = transform.position;

            Instantiate(thePlatform, transform.position, transform.rotation);
        }

        CreateObstacle();

        CreateCoins();

        
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
            transform.position = new Vector3(actualPlatPosition.x, actualPlatPosition.y , actualPlatPosition.z);
            if (count < 1 )
            {
                Instantiate(prefabObstacle, transform.position, transform.rotation);
                count++;
            }
        }

        if(numberWhenCreate != 2)
        {
            count = 0;
        }

       
    }

    public void CreateCoins()
    {
        if(numberWhenCreate == 1)
        {
            transform.position = new Vector3(actualPlatPosition.x + (count_2 * 2), actualPlatPosition.y, actualPlatPosition.z);
            if(count_2 < 3)
            {
                Instantiate(prefabCoin, transform.position, transform.rotation);
                count_2++;
            }

        }

        if(numberWhenCreate != 1)
        {
            count_2 = 0;
        }
    }
}
