using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class Ticket : MonoBehaviour
{
    public GameObject InteractMessage;
    public bool AtTicket = false;
    public TicketInspector TicketInspector;
    public GameObject UI;
    public InteractiveMessage InteractiveMessage;

    void OnTriggerStay2D(Collider2D collision)
    {
        InteractMessage.SetActive(true);
        AtTicket = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        InteractMessage.SetActive(false);
        AtTicket = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtTicket == true)
            {
                Object.Destroy(this.gameObject);
                TicketInspector.HasTicket = true;
                InteractiveMessage.DisplayMessage("You aquired a Train ticket- You might be able to get past the Instructor now!");

            }
        }
    }
}
