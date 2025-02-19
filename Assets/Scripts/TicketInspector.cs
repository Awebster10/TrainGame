using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class TicketInspector : MonoBehaviour
{
    public GameObject DeathMessage;
    public GameObject InteractMessage;
    public GameObject UI;

    public bool AtHim = false;
    public int NumOfVisits = 0;
    public bool HasTicket;

    public Death death;

    public AudioSource Glass;

    void OnTriggerStay2D(Collider2D collision)
    {
        InteractMessage.SetActive(true);
        AtHim = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        InteractMessage.SetActive(false);
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
                           UI.SetActive(true);
                           NumOfVisits++;
                       }
                       else if (NumOfVisits >= 1)
                       {
                           DeathMessage.SetActive(true);
                           death.IsDead = true;
                           Glass.Play();
                       }
                    }
                    else
                    {
                    Debug.Log("Level Passed");
                    }
                }
            }
    }
}
