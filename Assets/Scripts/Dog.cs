using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class Dog : MonoBehaviour
{
    public bool AtDog = false;
    public bool IsDogDead;

    public Animator animator;
    public GameObject Border;

    public Bird bird;
    public Death death;
    public InteractiveMessage InteractiveMessage;
    public KeyPress keyPress;
    public Dog DogScript;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (IsDogDead == false)
        {
            keyPress.DisplayMessage("Press E to Interact with Dog");
            AtDog = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (IsDogDead == false)
        {
            keyPress.RemoveMessage();
            AtDog = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (AtDog == true)
            {
                if (bird.HasBird == false)
                {
                    //Object.Destroy(this.gameObject);
                    death.Died("That is one mean dog that just ripped into your body, I bet it's called princess or something...");
                }
                else
                {
                    IsDogDead = true;
                    InteractiveMessage.DisplayMessage("That dog is really munching on that bird jeez... maybe you can get past him now");
                    keyPress.RemoveMessage();
                    animator.SetBool("DogIdle", true);
                    Border.SetActive(false);
                    DogScript.enabled = false;
                }
            }
            
        }
    }
}
