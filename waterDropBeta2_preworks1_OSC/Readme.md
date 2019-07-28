# waterDropBeta2 (3D)



## 목표

- 유니티 3D 활용법 확인

- OSC 사용하여 Max/MSP 연결



## 사용 에셋 및 리소스

- 에셋 스토어를 통해 extOSC 임포트 하여 활용 



## 구현 내용

- 3D 큐브를 생성 후 해당 큐브의 위치 값을 OSC를 통해 Max로 전달

- 위치 값을 Max에서 pitch로 사용하여 사운드 출력



# 프로젝트 구조

- Cube 오브젝트에 Transmitter 스크립트 적용
  - Transmitter 스크립트는 extOSC의 SimpleTransmitter에서 가져옴



# OSC

- osc 자체는 프로토콜로 네트워크
- Network
  - TCP:  Stable
  - UDP: Fast (음악 쪽에서는 거의 UDP 사용)



