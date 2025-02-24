using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class Wrench : MonoBehaviour
{
    public KeyPress keyPress;
    public bool AtWrench = false;
    public Gary Gary;
    public InteractiveMessage InteractiveMessage;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E to Pick Wrench up");
        AtWrench = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtWrench = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtWrench == true)
            {
                Gary.HasWrench = true;
                InteractiveMessage.DisplayMessage("You found a wrench in his pocket? I hear they're good for like detatching train crraiges for example");
                Object.Destroy(this.gameObject);
            }
        }
    }
}
