using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Writer : MonoBehaviour
{
    [SerializeField]Transform _pointA, _pointB;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move(_pointA, _pointB));
    }

    IEnumerator Move(Transform pA, Transform pB)
    {
        float duration = 2f;
        for (float i = 0; i < duration; i+= Time.deltaTime)
        {
            transform.position = Vector3.Lerp(pA.position, pB.position, i/duration);
            yield return null;
        }
        transform.position = pB.position;
    }
}
