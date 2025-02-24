using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject DeathScreen;
    public Movement movement;
    public bool ISit;
    public KeyPress keyPress;
    public TextMeshProUGUI Message;

    public Bird Bird;

    public void Died(string TheMessage)
    {
        keyPress.RemoveMessage();
        Message.text = TheMessage;
        DeathScreen.SetActive(true);
        movement.enabled = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
