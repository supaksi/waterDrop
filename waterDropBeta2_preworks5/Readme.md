# Mathf.Sin

x(t) = A sin(wt + phi)

# 물방울을 떨어트리는 주기

1일때 물을 떨어트려라
-> 0.8가 넘어 가면 나오도록
0.8 = threshold

2 가지를 관리해야함
- enter threshold
- exit threshold

다음과 같은 코드를 짜볼 수 있음
```
viod WaterSpwan()
{
	time +=Time.deltaTime;
	float sineVal = Mathf.Sin((2 * Mathf.PI * frequency * time) + phi;

	if (sineVal >= threshold) 
	{
		enterThreshold = true;
		exitThreshold = false;
	}

	else 
	{
		enterThreshold = false;
		exitThreshold = ture;
	}
	if 	(enterThreshold == ture && exitThreshold != ture)
	{
			Instantiate(waterPrefab, m_Position, Quarternion.identity);
	}
}	
```

이렇게 해봤으나...
0.8을 넘어서 1을 지나 다시 0.8 밑으로 떨어질 때 물방울이 연속으로 떨어짐...

여기서 한참 개삽질을 했는데..
threshold 개념에서 on/off 스위치 개념으로 바꾸어 생각

sineVal > upperThreshold 이면 스위치가 켜짐
sineVal < lowerThreshold 이면 스위치가 꺼짐


이렇게 바꿈..

```
float upperThreshold = 0.8f
float lowerThreshold = 0.0f

viod WaterSpwan()
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
```

즉 한번 작동하면 스위치를 꺼버리고
다시 - 값에 도달 하면 켜고 

이렇게 작동 시켜도 되지만 lowerThreshold는 무쓸모..
이것을 지워서 최종 정리하면

```
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
```
threshold를 넘으면 작동 후 꺼버리고
threshold보다 작아지면 켜버리고 (stand by 느낌)


여기서 아쉬운건... 주기 값 (frequency)를 전체 게임메니저에서 컨트롤 할 수 있도록 외부로 빼보자