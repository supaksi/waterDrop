# Noiseness

sine웨이브로 주기를 잡았지만 물방울이 규칙적으로 떨어지는 것이 불만족스러움
 -> 랜덤성을 추가해 보자

## 기존코드

- 물방울 스폰 코드
	```c#
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

	```

---
기존 threhold 지점에서 on /off 인데
주기적으로 움직이는 sine파형에 노이즈를 간섭시켜 threshold 지점에 도달 하지 못하게 하는 컨셉으로 랜덤을 적용 

## 신규코드

- noiseness
	```c#
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
	```