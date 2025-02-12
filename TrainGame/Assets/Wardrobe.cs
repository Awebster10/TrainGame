using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Box")

        {

            // Perform actions when colliding with the box

            Debug.Log("Died to Wardrobe!");

        }

    }
}
