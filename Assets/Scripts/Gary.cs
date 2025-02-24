using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class Gary : MonoBehaviour
{
    public InteractiveMessage interactiveMessage;
    public Movement movement;
    public GameObject PaintingUI;
    public GameObject Painting;
    public GameObject Ticket;
    public KeyPress keyPress;
    public TMP_InputField Code;
    public Animator animator;

    public bool AtGary;
    public bool GaryAwake;
    public string TheCode;
    public bool GaryDead;
    public bool HasWrench;
    


    public void Start()
    {
        int temp = UnityEngine.Random.Range(1001, 9999);
        TheCode = temp.ToString();
    }
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
                if (!GaryDead)
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
                else
                {
                    interactiveMessage.DisplayMessage("You found a wrench in his pocket? I hear they're good for like detatching train crraiges for example");
                    HasWrench = true;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (AtGary)
            {
                if (GaryAwake)
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
            animator.SetBool("GaryDead", true);
            Painting.SetActive(false);
            Ticket.SetActive(true);
            interactiveMessage.DisplayMessage("A ticket fell from behind that pinting that fell! What a coincidence");
            GaryDead = true;
        }
        else
        {
            Debug.Log("Wrong");
            PaintingUI.SetActive(false);
            movement.enabled = true;
        }
    }
}
