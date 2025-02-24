using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyLuggage : MonoBehaviour
{
    public KeyPress keyPress;
    public bool AtLuggage = false;
    public InteractiveMessage interactiveMessage;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E To open Luggage");
        AtLuggage = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtLuggage = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtLuggage == true)
            {
                interactiveMessage.DisplayMessage("That suitcase is just full of clothes. Bit of privacy please");
            }
        }
    }
}
