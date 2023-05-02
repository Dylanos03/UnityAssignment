using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inc : MonoBehaviour
{
    public float co2Val = 0f;
    public float DelayAmount = 0.03f;
    public Text textBox;

    protected float Timer;
    void Update()
    {
        Timer += Time.deltaTime;
        co2Val = (Timer * 33);
        textBox.GetComponent<UnityEngine.UI.Text>().text = co2Val.ToString("0.0");

        // if (Timer >= DelayAmount){
        //     Timer =0f;
        //     co2Val += 1;
        //     textBox.GetComponent<UnityEngine.UI.Text>().text = co2Val.ToString();
        // }
    }
}
