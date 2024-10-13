# 정렬

### 선택 정렬

- O(N^2)
- 가장 작은 것을 골라 제일 앞에 놓는 정렬
    
    ![{508A9DFA-5679-47B3-A747-E0F49915C110}.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/25c4633d-9fa8-4545-b62c-0c86e30da65f/88b53a61-591f-444a-ad44-e6a71ee131b3/508A9DFA-5679-47B3-A747-E0F49915C110.png)
    

### 버블 정렬

- O(N^2)
- 가까이 있는 두 수를 비교해서 더 작은 숫자를 앞으로 보내는 정렬
    
    ![{F28161CF-DD5D-4181-9EA6-E3F57E3378F7}.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/25c4633d-9fa8-4545-b62c-0c86e30da65f/6a4a6be4-c6ac-46d0-82f2-d1aa3c05cdf9/F28161CF-DD5D-4181-9EA6-E3F57E3378F7.png)
    

### 삽입 정렬

- O(N^2)
- while문을 이용하여 필요할 때만 정렬
- 거의 정렬된 상태라면 높은 효율을 보임
    
    ![{CF83245E-DFFE-4B10-9A39-B0CEAFAEEF5C}.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/25c4633d-9fa8-4545-b62c-0c86e30da65f/00714776-29f2-4db9-ba06-72ea78a61739/CF83245E-DFFE-4B10-9A39-B0CEAFAEEF5C.png)
    

### 퀵 정렬

- O(NlogN)
- 대표적인 분할 정복 알고리즘
- 최악의 경우 O(N^2)
    
    ![{7E696429-C5D6-4AFC-9301-2EE420393B69}.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/25c4633d-9fa8-4545-b62c-0c86e30da65f/db424f21-af1a-445a-b711-e7c93ee36220/7E696429-C5D6-4AFC-9301-2EE420393B69.png)
    

### 계수 정렬

- O(N) (범위 조건이 있는 특수한 경우)
    
    ![{4A5E9EEE-7263-4F48-92E0-528761323432}.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/25c4633d-9fa8-4545-b62c-0c86e30da65f/bd170d9f-e936-4a9c-a514-7e849460ebf6/4A5E9EEE-7263-4F48-92E0-528761323432.png)
    

### sort 다루기

- C++
    - 기본적으로 오름차순
    - compare함수를 통해 함수의 반환에 맞게 정렬
        - 참이면 그대로 거짓이면 바꾸기
- C#
    - C#은 람다식으로 사용자 지정 정렬이 가능
        - return이 1이면 b,a 순
        - return이 -1이면 a,b 순

### 정렬 문제

- 세 수 정렬
    - https://www.acmicpc.net/problem/2752
- 수 정렬하기 (단순 정렬)
    - https://www.acmicpc.net/problem/2750
- 수 정렬하기 2 (100만개 정렬)
    - https://www.acmicpc.net/problem/2751

### 심화 정렬

- 단어 정렬 (문자열 정렬)
    - https://www.acmicpc.net/problem/1181
- 시리얼 번호 (복잡한 문자열 정렬)
    - https://www.acmicpc.net/problem/1431
- 수 정렬하기 3 (매우 빠른 정렬)
    - https://www.acmicpc.net/problem/10989