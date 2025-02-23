using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Death : MonoBehaviour
{
    public GameObject DeathScreen;
    public Movement movement;
    public bool ISit;
    public KeyPress keyPress;
    public TextMeshProUGUI Message;

    public void Died(string TheMessage)
    {
        keyPress.RemoveMessage();
        Message.text = TheMessage;
        DeathScreen.SetActive(true);
        movement.enabled = false;
    }
}
