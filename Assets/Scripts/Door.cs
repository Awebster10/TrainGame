using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public KeyPress keyPress;
    public GameObject Player;
    public Gary gary;
    public Death death;

    public bool AtDoor;
    public int WhichLevel;
    public GameObject WinScreen;

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
                if (WhichLevel == 0)
                {
                    Player.transform.position = new Vector3(-9.89999962f, -1.5f, -2.84529996f);
                    gary.GaryAwake = true;
                }
                else if (WhichLevel == 1)
                {
                    Player.transform.position = new Vector3(-24.0499992f, 18.7074757f, -2.84529996f);
                }
                else if (WhichLevel == 2)
                {
                    if(!gary.HasWrench)
                    {
                        death.Died("You went out the carraige and couldnt get past the carraige connector- trying to get back you slipped off the train");
                    }
                    else
                    {
                        WinScreen.SetActive(true);
                    }
                }
            }
        }
    }
}
