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
    //public GameObject UI;
    public InteractiveMessage InteractiveMessage;
    private string TheMessage = ("You didnt want to eat the lovely cherry? Thats fine I guess, you may need it later...");


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
                InteractiveMessage.DisplayMessage(TheMessage);
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
