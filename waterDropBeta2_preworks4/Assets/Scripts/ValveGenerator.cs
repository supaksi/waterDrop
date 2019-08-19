using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveGenerator : MonoBehaviour
{
    public GameObject valvePrefab;
    public Vector3 instposition;

    private int valveNumber = 100;
    private int valveNumPerRow = 10;
    private float m_valveInterval = 2f;


    // Start is called before the first frame update
    void Start()
    {
        float valveXPosition = instposition.x;
        float valveZPosition = instposition.z;
        for (int i = 0; i < valveNumber; i++)
        {
            valveZPosition = (int)(i / valveNumPerRow) * m_valveInterval;
            valveXPosition = (int)(i % valveNumPerRow) * m_valveInterval;

            Vector3 generationPosition = new Vector3(valveXPosition, instposition.y, valveZPosition);
            Instantiate(valvePrefab, generationPosition, Quaternion.identity);
            valveXPosition += m_valveInterval;
            
        }
    }

}

