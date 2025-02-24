using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gary : MonoBehaviour
{
    public InteractiveMessage interactiveMessage;
    public KeyPress keyPress;

    public bool AtGary;

    void OnTriggerStay2D(Collider2D collision)
    {
        AtGary = true;
        keyPress.DisplayMessage("Press E to talk to Gary");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        AtGary = false;
        keyPress.RemoveMessage();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(AtGary)
            {
                interactiveMessage.DisplayMessage("...");
            }
        }
    }
}
