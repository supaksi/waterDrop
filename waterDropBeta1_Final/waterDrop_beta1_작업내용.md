# waterDrop_beta1 작업내용

1. 구름에서 물방울이 생성

2. 생성된 물방울이 지면으로 떨어짐

   2.1. 지면으로 떨어지는 각도, 방향은 랜덤으로

3. 지면에 떨어지면 물방울이 터지면서 사라짐



# 리소스 리스트

1. __사용한 리소스__

   - 이미지

     - 구름
     - 지면
     - 물방울 5개
     - 물봉울 터지는거 5개

   - 오디오

     - 떨어지고 터지고 1개

       

   __스크립트__

   - cloud 스크립트

     - 메인 스크립트
     - WaterWithArray 프리팹 소유

   - WaterWithArray 프리팹

     - waterWithArry 스크립트 소유
       - water 스프라이트 설정
       - splash 프리팹 설정

   - splah 프리팹

     - splash 스크립트 소유

     

# 작업 내용

1. 엣지 콜라이더 

   상하좌우 4면 설정

   

2. 프리팹 만들기

   프리팹 네임: (Coloer)Water

   

   2.1. 필요한 컴포넌트

   ​		Rigidbody2D 

   ​		Capsule Collider 2D

   

   2.2. 필요한 스크립트

   스크립트 네임: Waters 

   스크립트 내용: 생성 주기, 이동 방향(각도), 충돌처리

   

3. 스크립트 제작

   1. Waters 스크립트 제작

      구현사항:

      

   2. WaterSpawner 스크립트 제작

   

