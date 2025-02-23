using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractiveMessage : MonoBehaviour
{
    public GameObject InteractMessage;
    public TextMeshProUGUI Message;
    public Movement movement;

    public void DisplayMessage(string TheMessage)
    {
        InteractMessage.SetActive(true);
        Message.text = TheMessage;
        movement.enabled = false;
    }

    public void RemoveMessage()
    {
        InteractMessage.SetActive(false);
        movement.enabled = true;
    }
}
