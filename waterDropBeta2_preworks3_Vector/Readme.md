# Vector

- Scalar quantity: "양" 숫자
  - e.g) 너의 나이는 = 30
  - magnitute만 표기, 단순 숫자



- Vector: magnitude + direction
  - e.g) 힘(Force) : 9.81양 + 중력 방향



## 유니티에서 vector를 사용 하는 경우는?

- 3 Dimension
  - x,y,z를 사용



- Vector로 표현 하는 값들
  - Position
  - displacement
  -  Velocity (~speed)
  - acceleration
  - Force



## vector 표기법

- Typora 기준

  - $\vec{a}$

  - ```{.java}
    $\vec{a}$
    ```

- 절대값 표기
  
  - $\vec{|a|}$ :    absolute로 방향성 제외 하고 양 만 사용하는 경우



## 2D vector space

- vector는 방향과 양을 가짐

  - 화살표의 길이: magnitude

  - 화살표의 head: direction

    

![Screen Shot 2019-07-28 at 3.16.00 PM](https://user-images.githubusercontent.com/52766675/62003671-65d05780-b155-11e9-8181-f2d8af7da540.png)

- 표의 vector는 모두 같음, 다만 기점(postion) 이 다른 것

- Vector 일치 여부 2가지 조건

  1. Direction 이 동일한가

  2. Magnitude 가 동일한가

  (포지션은 고려 대상이 아님)



## Vector Addition

![Screen Shot 2019-07-28 at 3.27.49 PM](https://user-images.githubusercontent.com/52766675/62003676-94e6c900-b155-11e9-8e4e-438ad7d5f0fa.png)

- vector의 합

  - $\vec{a}$ + $\vec{b}$ = $\vec{c}$

  - (3,2) + (1,2) = (4.4)

- vector가 더 해지면 Direction이 달라짐
  - e.g) 선풍기 두개를 직각으로 두면?
    - 두 선풍기의 바람이 더 해져서 새로운 방향으로 물체가 날아감
    - 선풍기 두 개를 더 해 새로운 힘을 만들어 내는 것



## Vector Addition 쉬운 예시

- $\vec{a}$ , $\vec{b}$ 둘중 하나를 골라 해당 vector 의 tail을 나머지 vector의 head에 연결

  ![Screen Shot 2019-07-28 at 3.47.09 PM](https://user-images.githubusercontent.com/52766675/62003688-c2cc0d80-b155-11e9-8da0-5137eeaf7be6.png)





## inverse Vector

- $\vec{a}$ + $\vec{b}$ = $\vec{0}$
  - $\vec{b}$ = $\vec{-a}$ 

![Screen Shot 2019-07-28 at 3.49.16 PM](https://user-images.githubusercontent.com/52766675/62003695-cfe8fc80-b155-11e9-9d8b-9d6f289e0b10.png)



- zero vector
  -  $\vec{0}$ : magnitude가 0인 값 