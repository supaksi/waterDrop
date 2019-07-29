# waterDropBeta2 (3D)



## 목표

- 유니티 3D 활용법 확인

- OSC 사용하여 Max/MSP 연결



## 사용 에셋 및 리소스

- 에셋 스토어를 통해 extOSC 임포트 하여 활용 



## 구현 내용

- 3D 큐브를 생성 후 해당 큐브의 위치 값을 OSC를 통해 Max로 전달

- 위치 값을 Max에서 pitch로 사용하여 사운드 출력



# 프로젝트 제작 스텝 및 구조

1.  Empty Object로 OSC_Manager 생성

2.  OSC_Manager에 extOSC스크립트의  OSCTransmitter 적용

   - Use Bundle 활성화
   - 호스트와 포트 확인
     - 호스트: 127.0.0.1 (로컬)
     - 포트: 7000

3.  3D 오브젝트(Cube) 신규 생성 후 TransmitterTest 스크립트 적용

   - transmitterTest.cs 스크립트 확인

   - TransmitterTest 스크립트는 extOSC의 SimpleTransmitter에서 가져옴
     -  (설정상 Transmitter파일 명으로 사용 하면 애러남)

4.  Cube에 움직임을 줄 Move 스크립트 제작

   - unity game object oscillate 검색
   - Position version 확인 후 스크립트 복붙.. 
     - 복붙 후 필요에 맞게 수정

5. Cube의 움직임은 Sine 파형을 형상화

   ![small](https://user-images.githubusercontent.com/52766675/62026920-54e81a80-b217-11e9-878c-860e8eb54f34.png)

   - delta _t_ : 
   - _sin_(i) = y
   - magnitude = amplitude = y



6. y(t) = A _sine_(2πft + Φ)
   - radian freq : 2πf = w

# OSC

- osc 자체는 프로토콜로 네트워크
- Network
  - TCP:  Stable
  - UDP: Fast (음악 쪽에서는 거의 UDP 사용)



