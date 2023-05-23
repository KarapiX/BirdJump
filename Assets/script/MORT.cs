using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MORT : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "mort") 
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
   
    }
}
