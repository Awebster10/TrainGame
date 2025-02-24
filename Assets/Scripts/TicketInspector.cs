using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;
using UnityEngine.SceneManagement;

public class TicketInspector : MonoBehaviour
{
    public KeyPress keyPress;

    public bool AtHim = false;
    public int NumOfVisits = 0;
    public bool HasTicket;

    public Death death;
    public InteractiveMessage InteractiveMessage;

    public AudioSource Glass;
    public GameObject Border;
    public TicketInspector Script;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E to Speak to the Inspector");
        AtHim = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtHim = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            {
                if (AtHim == true)
                {
                    if (!HasTicket)
                    {
                        if (NumOfVisits == 0)
                        {
                            InteractiveMessage.DisplayMessage("He says dont come back to him without a ticket or else!");
                            NumOfVisits++;
                        }
                        else if (NumOfVisits >= 1)
                        {
                            death.Died("The Inspector doesnt take nicely to people boarding without a ticket. He thre you out a window. Bit brutal aint it?");
                            Glass.Play();
                        }
                    }
                    else
                    {
                        Border.SetActive(false);
                        InteractiveMessage.DisplayMessage("He accepted the ticket an dis now actually letting you through! He must be new");
                        Script.enabled = false;
                    }
                }
            }
    }
}
