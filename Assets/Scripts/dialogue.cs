using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue : MonoBehaviour
{

    private bool isClicked = false;
    private int dialogueIndex = 0;

    public Text caption;


    void dialogueSelect()
    {
        if (dialogueIndex == 0)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Welcome aboard!";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 1)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "During this flight, you will learn the effects of air travel and get some visual references";
            Debug.Log(dialogueIndex);
            isClicked = false;
        }else if (dialogueIndex == 2)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Outside your window is a little town called Snootville, and all the nature that surrounds it";
            Debug.Log(dialogueIndex);
            isClicked = false;
        }else if (dialogueIndex == 3)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Snootville is surrounded by the sea and mountains containing ice caps";
            Debug.Log(dialogueIndex);
            isClicked = false;
        }else if (dialogueIndex == 4)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "These 2 things put the town at serious risks with the increasing climate";
            Debug.Log(dialogueIndex);
            isClicked = false;
        }else if (dialogueIndex == 5)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Air travel is a big problem, private air travel being worse because of the lower amount of passengers";
            Debug.Log(dialogueIndex);
            isClicked = false;
        }else if (dialogueIndex == 6)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "If you look to the front of the plane, you will see a counter which displays the CO2 emissions of air travel";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 7)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Walk over to the chair in the back and press [E] to move on";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 8)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Now look outside of your window, notice anything different?";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 9)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Raising temperatures have already taken a toll on the town";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 10)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Ice caps ontop of the mountain have begun to melt, raising the sea level surrounding the town";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 11)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Grass and trees are drying out, killing off the greenery aswell as the animals";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 12)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "These are just some of the minor effects of global warming and look at the changes it is causing";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 13)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Return to your chair one last time";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 14)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Look out your windows again, i'm sure you can see a difference this time";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 15)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Due to the melting ice, sea levels have engulfed Snootville";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 16)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "All wildlife and plants are drowned by the water if not killed already by the heat";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 17)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Stopping unnecessary flights won't stop this from happening, but it is a step in the right direction";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex == 18)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "Help us stop this, thank you for playing";
            Debug.Log(dialogueIndex);
            isClicked = false;
        } else if (dialogueIndex > 18)
        {
            caption.GetComponent<UnityEngine.UI.Text>().text = "";
            Debug.Log(dialogueIndex);
            isClicked = false;
        }
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isClicked)
            {
                dialogueIndex++;
                isClicked = true;
                dialogueSelect();
            }
        }
    }
}
