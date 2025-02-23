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
    public bool HasBird = false;

    public Animator animator;

    public Cherry cherry;
    public Death death;
    public InteractiveMessage InteractiveMessage;

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
            if (!IsBirdDead)
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
            else
            {
                Object.Destroy(this.gameObject);
                InteractiveMessage.DisplayMessage("You have picked up a dead bird... Well done? Its said some animals like the taste of birds you know ...");
                HasBird = true;
            }
        }
    }
}
