using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManagement : MonoBehaviour
{
    private int factor = 1;
    void Update()
    {
        for (int i = 0; i < factor; i++)
        {
            Mathf.Sqrt(i);
        }
    }
}
