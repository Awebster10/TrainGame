using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;
using TMPro;

public class Bird : MonoBehaviour
{
    public GameObject DeathMessage;
    public GameObject InteractMessage;
    public TextMeshProUGUI Message;
    public bool AtBird = false;
    public bool IsBirdDead = false;

    public Animator animator;

    public Cherry cherry;
    public Death death;

    void OnTriggerStay2D(Collider2D collision)
    {
        InteractMessage.SetActive(true);
        AtBird = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        InteractMessage.SetActive(false);
        AtBird = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtBird == true)
            {
                if (cherry.HasCherry == false)
                {
                    DeathMessage.SetActive(true);
                    death.IsDead = true;
                }
                else
                {
                    IsBirdDead = true;
                    Message.text = ("Press E to pick up Bird Cage");
                    animator.SetBool("BirdDead", true);
                }
            }
        }
    }
}
