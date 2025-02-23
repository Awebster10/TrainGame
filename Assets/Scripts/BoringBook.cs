using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class BoringBook : MonoBehaviour
{
    public KeyPress keyPress;
    public bool AtBook = false;
    public Death death;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E To read the book");
        AtBook = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtBook = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtBook == true)
            {
                death.Died("That book was so boring it literally killed you. Haha fancy the odds of that");
                Object.Destroy(this.gameObject);
            }
        }
    }
}
