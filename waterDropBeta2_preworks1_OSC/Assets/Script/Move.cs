using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{ 
    float timeElapsed = 0;
    float speedCoefficient = 0.5f;
    float amplitude = 3f;

    void FixedUpdate()
    {
        timeElapsed = timeElapsed + Time.fixedDeltaTime;
        float magnitude = amplitude * Mathf.Sin((timeElapsed * speedCoefficient) * 2 * Mathf.PI);
        Vector3 newPos = transform.position;
        newPos.y = magnitude;

        transform.position = newPos;
    }
}
