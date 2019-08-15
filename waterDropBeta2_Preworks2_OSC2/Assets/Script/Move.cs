using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{ 

    public float speedCoefficient = 0.5f;
    public float amplitude = 3f;

    float m_timeElapsed = 0;
    Vector3 m_startPos;

    private void Start()
    {
        m_startPos = transform.position;
    }

    void FixedUpdate()
    {
        m_timeElapsed = m_timeElapsed + Time.fixedDeltaTime;
        float magnitude = amplitude * Mathf.Sin((m_timeElapsed * speedCoefficient) * 2 * Mathf.PI);
     
        transform.position = m_startPos + new Vector3(0, magnitude, 0);  
    }
}
