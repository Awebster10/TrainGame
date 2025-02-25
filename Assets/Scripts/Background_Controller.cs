using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Controller : MonoBehaviour
{
    private float startPos, length;
    public GameObject cam;
    public float parallaxEffect; // The speed at which the background should move relative tot the camera

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //calculate distance background move based on cam movement
        float distance = cam.transform.position.x * parallaxEffect; // 0 = move with cam || 1 = won't move || 0.5 = half speed
        float movement = cam.transform.position.x * (1 - parallaxEffect);

        transform.position = new Vector3(startPos + distance, transform.position.y, transform.position.z);

        //if background has reached the end of its length adjust its position for infinite scrolling
        if (movement > startPos + length)
        {
            startPos += length;
        }
        else if (movement < startPos - length)
        {
            startPos -= length;
        }
    }
}
