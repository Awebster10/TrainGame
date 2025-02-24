using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public KeyPress keyPress;

    public bool AtDoor;
    public int WhichLevel;

    void OnTriggerStay2D(Collider2D collision)
    {
        AtDoor = true;
        keyPress.DisplayMessage("Press E to go to the next Carraige");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        AtDoor = false;
        keyPress.RemoveMessage();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtDoor)
            {
                SceneManager.LoadScene(WhichLevel);
            }
        }
    }
}
