using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource Step;
    private int counter;
    private float Timer;

    void Update()
    {
        if (Input.GetKey(KeyCode.W | KeyCode.A | KeyCode.S | KeyCode.D))
        {
            Step.enabled = true;
        } else {
            Step.enabled = false;
        }

    }

    // void PlayStep()
    // {
        
        
    // }
}
