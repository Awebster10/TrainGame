using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class SpikyCussion : MonoBehaviour
{
    public GameObject DeathScreen;
    public GameObject InteractMessage;
    public bool AtCussion = false;

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
                    Debug.Log("Hehe");
                    if(AtCussion == true)
                    {
                    DeathScreen.SetActive(true);}
            }
    }
}
