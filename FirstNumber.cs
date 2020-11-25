using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstNumber : MonoBehaviour
{
    public static int number;

    private void Awake()
    {
        number = Random.Range(1, 10);
        var text = GetComponentInChildren<Text>();
        text.text = "" + number;
    }
}
