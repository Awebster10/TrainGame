using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luggage : MonoBehaviour
{
    public KeyPress keyPress;
    public bool AtLuggage = false;
    public Death death;

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
                death.Died("That Suitcase had a bomb in it- did you not know that?");
                //Object.Destroy(this.gameObject);
            }
        }
    }
}
