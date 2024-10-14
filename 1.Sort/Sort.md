# 정렬

### 선택 정렬

- O(N^2)
- 가장 작은 것을 골라 제일 앞에 놓는 정렬

    ![Selection_sort_animation](https://github.com/user-attachments/assets/8cd88a32-bf78-42af-b92c-891aeb5942ee)



### 버블 정렬

- O(N^2)
- 가까이 있는 두 수를 비교해서 더 작은 숫자를 앞으로 보내는 정렬
    
    ![Bubble_sort_animation](https://github.com/user-attachments/assets/057af744-c364-4b39-9d3d-7ceebf7bd81d)


### 삽입 정렬

- O(N^2)
- while문을 이용하여 필요할 때만 정렬
- 거의 정렬된 상태라면 높은 효율을 보임
    
    ![Insertion_sort_animation](https://github.com/user-attachments/assets/ba4e2f41-b489-4afc-892d-3902aeffe472)


### 퀵 정렬

- O(NlogN)
- 대표적인 분할 정복 알고리즘
- 최악의 경우 O(N^2)

    ![Sorting_quicksort_anim](https://github.com/user-attachments/assets/9c8cb515-371d-4447-b00f-20c108e39bf7)


### 계수 정렬

- O(N) (범위 조건이 있는 특수한 경우)
    

    

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

### 이미지 출처
https://ko.wikipedia.org/wiki/%EC%A0%95%EB%A0%AC_%EC%95%8C%EA%B3%A0%EB%A6%AC%EC%A6%98
