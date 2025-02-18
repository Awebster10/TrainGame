using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class BoringBook : MonoBehaviour
{
    public GameObject DeathMessage;
    public GameObject InteractMessage;
    public bool AtBook = false;
    public Death death;

    void OnTriggerStay2D(Collider2D collision)
    {
        InteractMessage.SetActive(true);
        AtBook = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        InteractMessage.SetActive(false);
        AtBook = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtBook == true)
            {
                DeathMessage.SetActive(true);
                death.IsDead = true;
            }
        }
    }
}
