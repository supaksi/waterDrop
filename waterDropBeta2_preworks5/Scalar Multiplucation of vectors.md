# Scalar Multiplucation of vectors

- vector의 합
  - c(A + B) = cA+cB

<img width="263" alt="Screen Shot 2019-08-03 at 3 14 40 PM" src="https://user-images.githubusercontent.com/52766675/62408289-90ad2680-b601-11e9-9192-cc485024c8d3.png">



- (-)마이너스 Vector
  - 백터에서 마이너스는 음수가 아님
  - __반대 방향__



# unit vector

- vector / magnitude = unit vector

  - <img width="164" alt="Screen Shot 2019-08-03 at 3 21 21 PM" src="https://user-images.githubusercontent.com/52766675/62408326-6314ad00-b602-11e9-923a-85378078b335.png">
  - 결국 백터를 메그니튜드 백터로 나눈 것
    - 값은 항상 1
  - $\vec{a}$ / $\vec{|a|}$ 

  

- 유닛 백터를 사용하면 1의 그리드가 생김으로 직관적인 처리가 가능

  

# Coordinate System

- 물리의 개념을 수학을 통해 표현 하기 위해 사용
  - origin
  - axes
  - Positive direcetion
  - Unit vector



- Coordinate System은 3가지로 나윔

  1. Cartesian Coordinate

  2. Cylinderical Coordinate

  3. Spherical Coordinate

     



## Cartesian Coordinate (polar)

- 일반적인 십자 그래프

  <img width="570" alt="Screen Shot 2019-08-03 at 3 41 34 PM" src="https://user-images.githubusercontent.com/52766675/62408512-344c0600-b605-11e9-9005-87bac6bad0a8.png">

  - 오른쪽으로 가면 x가 크고, 왼쪽으로 가면 y가 크고
  - Origin이 중요
    - 선이 겹치는 중심을 직관적으로 orgin이라 생각
    - 하지만 Orgin의 위치는 임으로 설정 되어도 무방
      - unity에서 오브젝트가 움직이는 것은 orgin이 움직이는 것으로 보면 됨

- 용어 관례
  - 3D: i, j ,k



## Cylindrical Coordinate

<img width="306" alt="Screen Shot 2019-08-03 at 3 45 31 PM" src="https://user-images.githubusercontent.com/52766675/62408552-c3f1b480-b605-11e9-9a24-2a3b2905a7df.png">



- 설명
  1. 세타: x축에서 세타(0) 각으로 벗어나 있음
  2. r(radius): 얼마만큼 벗어나 있는지 반지름이 나옴
  3. z축: 원점에서 z축이 얼마나 벗어나 있는지 확인 (초록색)
  4. 이 세가지 값을 더하면 원점(Origin)에서 얼마나 벗어나 있는지 값이 나옴 (파란색)





## 시스템 활용

- 위 2가지 방법 다 사용
- 상황에 따라 맞게 활용
  - 전지 전능한 시점: Cartesian 이 편리
  - 1인칭 시점: Polar coordinate



## 피타고라스 정리

<img width="501" alt="Screen Shot 2019-08-03 at 4 05 31 PM" src="https://user-images.githubusercontent.com/52766675/62408751-8cd0d280-b608-11e9-99eb-c04972acb7d2.png">

- 이 거에 따라서 cartesian이 polar 서로 교환 해 가며 사용 가능





# Kinematics

- 포지션, 벨로시티, 엑셀레이터등을 수학으로 표현

  

- Position vector

- displacement vector

- velocity vector

  - 시간당 위치 변화
    - 1초 동안 얼마나 멀리 갔느냐
    - 멀리 갔음 벨로 시티가 높은거고 

- Acceration vetor

  - 시간당 velocity 변화 (모호 한 개념)

  - e.g) 사과를 위로 던지면
    - 위로 올라가다 
    - 어느 순간이 되면 멈춤



- $\vec{F}$ =m$\vec{a}$ 

