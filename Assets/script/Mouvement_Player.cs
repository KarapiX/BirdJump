using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement_Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = speed * Vector2.up;

        }
    }
}
