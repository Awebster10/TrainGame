using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject DeathScreen;
    public Movement movement;
    public bool IsDead;

    void Update()
    {
        if(IsDead == true)
        {
            DeathScreen.SetActive(true);
            movement.enabled = false;
        }
    }
}
