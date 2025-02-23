using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class Cherry : MonoBehaviour
{
    public GameObject InteractMessage;
    public bool AtCherry = false;
    public bool HasCherry = false;

    public GameObject DeathMessage;
    public Death death;
    public GameObject UI;

    void OnTriggerStay2D(Collider2D collision)
    {
        InteractMessage.SetActive(true);
        AtCherry = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        InteractMessage.SetActive(false);
        AtCherry = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtCherry == true)
            {
                HasCherry = true;
                Object.Destroy(this.gameObject);
                UI.SetActive(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (AtCherry == true)
            {
                DeathMessage.SetActive(true);
                death.IsDead = true;
            }
        }
    }
}
