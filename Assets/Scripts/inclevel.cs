using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inclevel : MonoBehaviour
{
    public int level = 0;
    public GameObject plane;
    public GameObject sit;
    private bool changeOnce = false;

    public Material skyBox1;
    public Material skyBox2;

    // Update is called once per frame
    void ChangeLevel()
    {
        if (sit.activeSelf){
            level++;
            if (level > 2){
                level = 0;
            }
            Debug.Log(level);
            if (level == 0)
            {
                plane.transform.position = new Vector3(302, 59, 372);
                RenderSettings.skybox = skyBox1;
            } else if (level == 1)
            {
                plane.transform.position = new Vector3(302, 59, -1661);
                RenderSettings.skybox = skyBox1;
            } else if (level == 2)
            {
                plane.transform.position = new Vector3(1850, 59, -646);
                RenderSettings.skybox = skyBox2;
            }
        }
    }

    void Update()
    {
        if (sit.activeSelf){
            if (!changeOnce){
                ChangeLevel();
                changeOnce = true;
            }
        }
        if (!sit.activeSelf){
            changeOnce = false;
        }
    }
}
