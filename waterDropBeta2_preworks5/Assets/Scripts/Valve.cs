using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    public GameObject waterPrefab;
    public float frequency = 2f;
    
    private Vector3 m_Position;

    private float time;
    private float phi;
    private float threhold = 0.8f;
    bool swith = false;

    void Start()
    {
        m_Position = transform.position;
        phi = Random.Range(0.0f, Mathf.PI * 2);
        time = 0.0f;
              
    }

    private void Update()
    {
        time += Time.deltaTime;
        WaterSpwan(time);

    }

    void WaterSpwan (float t)
    {
        float sineVal = Mathf.Sin((2 * Mathf.PI * frequency * t) + phi);

        if(sineVal < threhold)
        {
            swith = true;

        }
        if(swith == true && sineVal > threhold)
        {
            Instantiate(waterPrefab, m_Position, Quaternion.identity);
            swith = false;
        }
    }
}
