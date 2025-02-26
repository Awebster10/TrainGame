using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint_System : MonoBehaviour
{
    public bool AtHint;

    public InteractiveMessage interactiveMessage;
    public KeyPress keyPress;
    public Bird Bird;
    public Cherry cherry;
    public Dog dog;
    public Gary gary;
    public TicketInspector ticketInspector;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E to get a hint");
        AtHint = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtHint = false;
    }


    public void Update()
    {
        if (AtHint)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (cherry.HasCherry != true)
                {
                    interactiveMessage.DisplayMessage("Those berries dont look good to eat... Maybe they can be picked up for later use...");
                }
                else if (cherry.HasCherry && !Bird.HasBird)
                {
                    interactiveMessage.DisplayMessage("I've heard that birds like the tast of cherries, maybe it'll like the one in your pocket");
                }
                else if (Bird.HasBird && !dog.IsDogDead)
                {
                    interactiveMessage.DisplayMessage("Dogs like the taste of birds right? Maybe it'll distract it.");
                }
                else if (dog.IsDogDead && gary.GaryAwake && !gary.LookForCode)
                {
                    interactiveMessage.DisplayMessage("Interesting painting taht wasnt it? Maybe a closer look is needed");
                }
                else if (gary.LookForCode && !gary.GaryDead)
                {
                    interactiveMessage.DisplayMessage("The code for the painting has to be somewhere right? Maybe in one of these luggage cases...");
                }
                else if (ticketInspector.HasTicket && !gary.HasWrench)
                {
                    interactiveMessage.DisplayMessage("Maybe I need a tool to disconnect the carraiges.... Maybe I should check Gary again");
                }
            }
        }
    }
}
