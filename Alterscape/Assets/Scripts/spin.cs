using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    [SerializeField] float spinSpeed = 360.0f;

    void Update()
    {
        transform.Rotate(0.0f, spinSpeed * Time.deltaTime, 0.0f);
    }
}
