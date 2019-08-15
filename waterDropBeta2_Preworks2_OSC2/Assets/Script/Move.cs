using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{ 
    float timeElapsed = 0;
    float speedCoefficient = 0.5f;
    public float amplitude = 3f;

    void FixedUpdate()
    {
        timeElapsed = timeElapsed + Time.fixedDeltaTime;
        float magnitude = amplitude * Mathf.Sin((timeElapsed * speedCoefficient) * 2 * Mathf.PI);

        // 현재 위치를 newPos에 저장
        Vector3 newPos = transform.position;
        newPos.y = newPos.y + magnitude;

        // 업데이트 된 Vector 값을 position으로 설정 (이건 좋은 코드는 아님 데모를 위해서 간편하게 적용)
        transform.position = newPos;  
    }
}
