using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    [SerializeField] GameObject waterPrefab;
    [SerializeField] float frequency = 2f;
    [SerializeField] [Range(0f, 1.0f)] float randomness;

    private Vector3 m_Position;

    private float time;
    private float phaseOffset;
    private float threhold = 0.8f;
    bool swith = false;

    void Start()
    {
        m_Position = transform.position;
        phaseOffset = Random.Range(0.0f, Mathf.PI * 2); //from 0 degree to 2PI
        time = 0.0f;
    }

    private void Update()
    {
        time += Time.deltaTime;
        WaterSpwan(time);

    }

    void WaterSpwan (float t)
    {
        // sine oscillator: Sin((2pif * t); + phi)
        float sineVal = Mathf.Sin((2 * Mathf.PI * frequency * t) + phaseOffset);

        // noise
        float randomVal = Random.Range(-1.0f, 1.0f);
        float mixVal = MixValue(sineVal, randomVal, randomness);

        if(mixVal < threhold)
        {
            swith = true;

        }
        if(swith == true && mixVal > threhold)
        {
            Instantiate(waterPrefab, m_Position, Quaternion.identity);
            swith = false;
        }
    }

    float MixValue(float InputA, float InputB, float bAmount)
    {

        return (InputA * (1.0f - bAmount)) + (InputB * bAmount);  
    }
}
