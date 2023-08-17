using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class character : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float jumpforce = 100f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ground")
        {
            rb.AddForce(Vector2.up*jumpforce);
            Debug.Log("test");
        }
    }  
}
