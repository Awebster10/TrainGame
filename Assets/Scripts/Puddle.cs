using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puddle : MonoBehaviour
{
    public Death death;

    void OnTriggerEnter2D(Collider2D collision)
    {
        death.Died("Watch your step, you slipped in a puddle and broke your neck :(");
    }


}
