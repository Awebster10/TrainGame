using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class Ticket : MonoBehaviour
{
    public KeyPress keyPress;
    public bool AtTicket = false;
    public TicketInspector TicketInspector;
    public InteractiveMessage InteractiveMessage;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E to Pick Ticket up");
        AtTicket = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
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
