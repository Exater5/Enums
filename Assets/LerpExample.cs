using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExample : MonoBehaviour
{
    [Range(0f, 1f)] public float progress;
    public Transform pointA, pointB;

    // Update is called once per frame
    void Update()
    {
        //Punto A hasta Punto B
        transform.position = Vector3.Lerp(pointA.position, pointB.position, progress);

        //Seguimiento estilo Amoung Us
        transform.position = Vector3.Lerp(transform.position, pointB.position, Time.deltaTime * 5f);
    }
}
