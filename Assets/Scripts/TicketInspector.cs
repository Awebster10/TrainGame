using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class TicketInspector : MonoBehaviour
{
    public GameObject DeathMessage;
    public GameObject InteractMessage;
    public bool AtHim = false;
    public Death death;
    public bool HasTicket;

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
                        DeathMessage.SetActive(true);
                        death.IsDead = true;
                    }
                    else
                    {
                    Debug.Log("Level Passed");
                    }
                }
            }
    }
}
