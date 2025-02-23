using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject DeathScreen;
    public Movement movement;
    public bool IsDead;
    public KeyPress keyPress;

    void Update()
    {
        if(IsDead == true)
        {
            keyPress.RemoveMessage();
            DeathScreen.SetActive(true);
            movement.enabled = false;
        }
    }
}
