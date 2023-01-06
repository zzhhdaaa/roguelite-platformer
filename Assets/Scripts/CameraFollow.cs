using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    
    void Update()
    {
        var camPos = transform.position;
        camPos.x = player.position.x;
        camPos.y = player.position.y + 2;
        transform.position = camPos;
    }
}
