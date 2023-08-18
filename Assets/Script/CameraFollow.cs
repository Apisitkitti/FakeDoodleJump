using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private float latestposition =0f;
    void Update()
    {
        if(player.position.y>latestposition)
        {
             transform.position = new Vector3(0, player.position.y,-10);
            latestposition = player.position.y;
        }
           
    }
}
