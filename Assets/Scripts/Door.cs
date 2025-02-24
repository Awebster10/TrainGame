using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public KeyPress keyPress;
    public GameObject dog;
    public GameObject Player;

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
                dog.SetActive(false);
                SceneManager.LoadScene(WhichLevel);
                Player.transform.position = new Vector3(-16.6399994f, 0.419999987f, -2.82740283f);
            }
        }
    }
}
