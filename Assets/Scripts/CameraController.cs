using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public PlayerController thePlayer;

    private Vector3 _lastPlayerPosition;
    private float _distanceToMove;
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        _lastPlayerPosition = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _distanceToMove = thePlayer.transform.position.x - _lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + _distanceToMove, transform.position.y, transform.position.z); 

        _lastPlayerPosition = thePlayer.transform.position;
    }
}
