using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyPress : MonoBehaviour
{
    public GameObject keyPress;
    public TextMeshProUGUI Message;

    public void DisplayMessage(string TheMessage)
    {
        keyPress.SetActive(true);
        Message.text = TheMessage;
    }

    public void RemoveMessage()
    {
        keyPress.SetActive(false);
    }
}
