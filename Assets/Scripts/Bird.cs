using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;
using TMPro;

public class Bird : MonoBehaviour
{
    public TextMeshProUGUI Message;
    public bool AtBird = false;
    public bool IsBirdDead = false;
    public bool HasBird = false;
    public GameObject TheBird;

    public Animator animator;

    public Cherry cherry;
    public Death death;
    public InteractiveMessage InteractiveMessage;
    public KeyPress keyPress;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E to Interact with Bird");
        AtBird = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
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
                        Object.Destroy(this.gameObject);
                        death.Died("Why on earth would you pet a random bird? It pecked your eyes out and is eating them- it loves to eat stuff...");
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
                TheBird.SetActive(false);
                InteractiveMessage.DisplayMessage("You have picked up a dead bird... Well done? Its said some animals like the taste of birds you know ...");
                HasBird = true;
            }
        }
    }
}
