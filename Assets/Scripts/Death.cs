using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject DeathScreen;
    public Movement movement;
    public KeyPress keyPress;
    public TextMeshProUGUI Message;
    public AudioSource trainsound;
    public Bird Bird;

    public void Died(string TheMessage)
    {
        keyPress.RemoveMessage();
        Message.text = TheMessage;
        DeathScreen.SetActive(true);
        movement.enabled = false;
        trainsound.Stop();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
