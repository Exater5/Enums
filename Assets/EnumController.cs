using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumController : MonoBehaviour
{
    public GameObject[] elements;
    public enum CubeColors { Blue, Red, White, Green};

    void Start()
    {
        //Blue -- > 0
        //Red -- > 1
        //White -- > 2
        //Green -- > 3
        elements[(int)CubeColors.Blue].SetActive(false);
    }
}
