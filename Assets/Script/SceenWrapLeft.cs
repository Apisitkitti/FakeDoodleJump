using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceenWrapLeft : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.gameObject.transform.position = new Vector3(12.06f,other.transform.position.y,-5f);
        }
    } 
    
}
