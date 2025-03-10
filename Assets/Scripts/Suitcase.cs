using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class Suitcase : MonoBehaviour
{
    public KeyPress keyPress;
    public GameObject Ticket;
    public bool AtSuitcase = false;
    public InteractiveMessage interactiveMessage;
    public Gary Gary;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E To open suitcase");
        AtSuitcase = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtSuitcase = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtSuitcase == true)
            {
                interactiveMessage.DisplayMessage("You found a note which just says the numbers:" + Gary.TheCode);
            }
        }
    }
}
