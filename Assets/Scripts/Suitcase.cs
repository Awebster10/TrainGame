using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class Suitcase : MonoBehaviour
{
    public GameObject InteractMessage;
    public GameObject Ticket;
    public bool AtSuitcase = false;

    void OnTriggerStay2D(Collider2D collision)
    {
        InteractMessage.SetActive(true);
        AtSuitcase = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        InteractMessage.SetActive(false);
        AtSuitcase = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtSuitcase == true)
            {
                Ticket.SetActive(true);
                Object.Destroy(this.gameObject);
            }
        }
    }
}
