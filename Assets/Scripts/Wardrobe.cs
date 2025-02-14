using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wardrobe : MonoBehaviour
{
    public GameObject DeathScreen;

    void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.tag == "Box")

        {

            // Perform actions when colliding with the box

            Debug.Log("Died to Wardrobe!");
            DeathScreen.SetActive(true);

        }

    }
}
