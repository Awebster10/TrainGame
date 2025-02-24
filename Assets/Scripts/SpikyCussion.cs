using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class SpikyCussion : MonoBehaviour
{
    public bool AtCussion = false;

    public Death death;
    public KeyPress keyPress;
    public AudioSource Stabsound;

    void OnTriggerStay2D(Collider2D collision)
    {
        keyPress.DisplayMessage("Press E to sit on Cussion");
        AtCussion = true;
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        keyPress.RemoveMessage();
        AtCussion = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(AtCussion == true)
            {
                death.Died("You were Impaled by the Spiky cussion you foolishly decided to sit on");
                Stabsound.Play();
                //Object.Destroy(this.gameObject);
            }
        }
    }
}
