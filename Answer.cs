using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour
{
    public InputField text;
    public GameObject cam;
    public int i;
    public string s;

    private void Start()
    {
        text = GetComponentInChildren<InputField>();
        i = FirstNumber.number * SecondNumber.number;
        s = i.ToString();
    }

    public void CheckAnswer()
    {
        if(text.text == s)
        {
            var camPos = cam.GetComponent<Camera>();
            camPos.PositionBoth();
        }
    }
}
