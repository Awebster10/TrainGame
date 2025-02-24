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
    public GameObject Wrench;
    public KeyPress keyPress;
    public TMP_InputField Code;
    public Animator animator;
    public Gary gary;

    public bool AtGary;
    public bool GaryAwake;
    public string TheCode;
    public bool GaryDead;
    public bool HasWrench;
    private string Message = "Press E to talk to Gary";
    


    public void Start()
    {
        int temp = UnityEngine.Random.Range(1001, 9999);
        TheCode = temp.ToString();
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        AtGary = true;
        keyPress.DisplayMessage(Message);
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
                    Wrench.SetActive(true);
                    gary.enabled = false;
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
            Message = "Press E to Search Garys body";
        }
        else
        {
            interactiveMessage.DisplayMessage("Nothing Happened- Maybe you got it wrong?");
            PaintingUI.SetActive(false);
            movement.enabled = true;
        }
    }
}
