using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class SpikyCussion : MonoBehaviour
{
    public GameObject DeathMessage;
    public GameObject InteractMessage;
    public bool AtCussion = false;
    public Death death;

    void OnTriggerStay2D(Collider2D collision)
    {
        InteractMessage.SetActive(true);
        AtCussion = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        InteractMessage.SetActive(false);
        AtCussion = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            {
                if(AtCussion == true)
                {
                    DeathMessage.SetActive(true);
                    death.IsDead = true;
                }
            }
    }
}
