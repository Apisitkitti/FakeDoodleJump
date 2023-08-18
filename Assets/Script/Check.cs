using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Check : MonoBehaviour
{
  public CapsuleCollider2D cap;
   void OnTriggerStay2D(Collider2D other)
   {
        if(other.gameObject.tag == "ground"||other.gameObject.tag == "Superjump")
        {
           cap.isTrigger = true;
        }
   }
   void OnTriggerExit2D(Collider2D other)
   {
     if(other.gameObject.tag == "ground"||other.gameObject.tag == "Superjump")
        {
           cap.isTrigger = false;
        }
   }
    
}
