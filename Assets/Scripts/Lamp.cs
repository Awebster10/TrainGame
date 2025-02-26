using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    public KeyPress keyPress;
    public bool AtLamp = false;
    public Death death;
    public int numberOfpressed;
    public Animator animator;
    public bool LampOn;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E To turn the lamp on");
        AtLamp = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtLamp = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtLamp == true)
            {
                if (numberOfpressed < 3)
                {
                    if (!LampOn)
                    {
                        LampOn = true;
                        animator.SetBool("Lamp_On", true);
                        numberOfpressed++;
                    }
                    else if(LampOn)
                    {
                        LampOn = false;
                        animator.SetBool("Lamp_On", false);
                        numberOfpressed++;
                    }
                }
                else if(numberOfpressed <= 3)
                {
                    death.Died("Woah! That lamp literally blew up in your face");
                }
            }
        }
    }
}

