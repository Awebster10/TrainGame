using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class BookCase : MonoBehaviour
{
    public KeyPress keyPress;
    public bool AtBook = false;
    public GameObject boringBook;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E To look at bookcase");
        AtBook = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtBook = false;
    }

    void Update()
    {   
        if (AtBook == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                boringBook.SetActive(true);
                this.enabled = false;
            }
        }
    }
}
