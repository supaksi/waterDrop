using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveGenerator : MonoBehaviour
{
    public GameObject valvePrefab;
    [SerializeField] public Vector3 positionOffset;
    [SerializeField] public float valveInterval = 2f;

    private int valveNumber = 100;
    private int valveNumPerRow = 10;

    // Start is called before the first frame update
    public void BuildValves()
    {
        for (int i = 0; i < valveNumber; i++)
        {
            float valveXPosition = (int)(i % valveNumPerRow) * valveInterval;
            float valveZPosition = (int)(i / valveNumPerRow) * valveInterval;
            Vector3 generationPosition = new Vector3(valveXPosition + positionOffset.x, positionOffset.y, valveZPosition + positionOffset.z);
            Instantiate(valvePrefab, generationPosition, Quaternion.identity);
        }
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        for (int i = 0; i < valveNumber; i++)
        {
            float valveXPosition = (int)(i % valveNumPerRow) * valveInterval;
            float valveZPosition = (int)(i / valveNumPerRow) * valveInterval;
            Vector3 generationPosition = new Vector3(valveXPosition + positionOffset.x, positionOffset.y, valveZPosition + positionOffset.z);
            Gizmos.DrawWireSphere(generationPosition, 1);
        }
    }
}

