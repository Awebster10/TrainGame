using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;
using TMPro;

public class Cherry : MonoBehaviour
{
    public bool AtCherry = false;
    public bool HasCherry = false;
    public string Message = ("Press E to Pick up the Berry or Press F to eat The Berry");

    public Death death;
    public KeyPress keyPress;
    public InteractiveMessage InteractiveMessage;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage(Message);
        AtCherry = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtCherry = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtCherry == true)
            {
                HasCherry = true;
                InteractiveMessage.DisplayMessage("You didnt want to eat the lovely cherry? Thats fine I guess, you may need it later...");
                Message = ("Press F to eat the Berry");
            }
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (AtCherry == true)
            {
                //Object.Destroy(this.gameObject);
                death.Died("Why on earth would you eat a random berry you found? Anyway yeah it messed your insides out- your dead buddy.");
            }
        }
    }
}
