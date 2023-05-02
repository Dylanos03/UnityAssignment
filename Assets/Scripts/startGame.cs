using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject startCam;
    public GameObject canvas;
    public GameObject startCanvas;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            mainCam.SetActive(true);
            startCam.SetActive(false);
            canvas.SetActive(true);
            startCanvas.SetActive(false);
        }
    }
}
