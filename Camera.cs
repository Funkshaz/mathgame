using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform prefab;
    void Start()
    {
        PositionLength();
        for (int length = 0; length < FirstNumber.number; length++)
        {
            for(int width = 0; width < SecondNumber.number; width++)
            {
                Instantiate(prefab, new Vector3(length * 2, 0, width * 2), Quaternion.identity);
            }

        }

    }

    public void PositionLength()
    {

        transform.position = new Vector3(FirstNumber.number - 1, 0, -20);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void PositionWidth()
    {
        transform.position = new Vector3(-20, 0, SecondNumber.number - 1);
        transform.rotation = Quaternion.Euler(0, 90, 0);
    }

    public void PositionBoth()
    {
        transform.position = new Vector3(FirstNumber.number-1, 20, SecondNumber.number-1);
        transform.rotation = Quaternion.Euler(90, 0, 0);
    }
}
