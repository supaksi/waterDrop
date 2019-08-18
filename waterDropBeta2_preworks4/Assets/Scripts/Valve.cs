using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valve : MonoBehaviour
{
    public GameObject waterPrefab;

    private Vector3 m_Position;

    // Start is called before the first frame update
    void Start()
    {
        m_Position = transform.position;
        Instantiate(waterPrefab, m_Position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
