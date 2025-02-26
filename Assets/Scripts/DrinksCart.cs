using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinksCart : MonoBehaviour
{
    public KeyPress keyPress;
    public bool AtDrinksCart = false;
    public Death death;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E To Pour a drink");
        AtDrinksCart = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtDrinksCart = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtDrinksCart == true)
            {
                death.Died("You really cannot handle your drinks... it absolutley burned through your stomach");
                //Object.Destroy(this.gameObject);
            }
        }
    }
}

