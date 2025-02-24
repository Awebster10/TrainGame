using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gary : MonoBehaviour
{
    public InteractiveMessage interactiveMessage;
    public Movement movement;
    public GameObject PaintingUI;
    public KeyPress keyPress;
    public TMP_InputField Code;

    public bool AtGary;
    public bool GaryAwake;
    public string TheCode = "1385";

    void OnTriggerStay2D(Collider2D collision)
    {
        AtGary = true;
        keyPress.DisplayMessage("Press E to talk to Gary");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        AtGary = false;
        keyPress.RemoveMessage();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(AtGary)
            {
                if (GaryAwake)
                {
                    interactiveMessage.DisplayMessage("You got any dope? God I love drugs");

                }
                else
                {
                    interactiveMessage.DisplayMessage("ZZZ...ZZZ...ZZZ");
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (AtGary)
            {
                if (!GaryAwake)
                {
                    PaintingUI.SetActive(true);
                    movement.enabled = false;
                }
            }
        }
    }
    public void InputCode()
    {
        if(Code.text == TheCode)
        {
            Debug.Log("Correct");
            PaintingUI.SetActive(false);
            movement.enabled = true;
        }
        else
        {
            Debug.Log("Wrong");
            PaintingUI.SetActive(false);
            movement.enabled = true;
        }
    }
}
