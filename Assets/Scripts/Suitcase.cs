using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class Suitcase : MonoBehaviour
{
    public KeyPress keyPress;
    public GameObject Ticket;
    public bool AtSuitcase = false;

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
                Ticket.SetActive(true);
                Object.Destroy(this.gameObject);
            }
        }
    }
}
