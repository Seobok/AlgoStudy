# 스택, 큐

### 스택, 큐, 우선순위 큐

- 스택
    - 후입 선출 (LIFO - Last In First Out)
    - 자료를 넣는 것을 '밀어넣는다' 하여 **푸쉬**(push)
    - 반대로 넣어둔 자료를 꺼내는 것을 **팝**(pop)
    - 나중에(최근에) 넣은(푸쉬한) 값이 먼저 나오게 된다.
- 큐
    - 선입 선출 (FIFO - First In First Out)
    - put(insert)는 큐에 자료를 넣는 것
    - get(delete)은 큐에서 자료를 꺼내는 것
    - front(head)와 rear(tail)는 데이터의 위치를 가리킨다.
        - front는 데이터를 get할 수 있는 위치를, rear은 데이터를 put할 수 있는 위치를 의미한다.
- 우선순위 큐
    - **우선순위 큐(Priority Queue)**는 먼저 들어오는 데이터가 아니라, 우선순위가 높은 데이터가 먼저 나가는 형태의 자료구조이다.
    - 우선순위 큐는 일반적으로 **힙(Heap)**을 이용하여 구현한다.
        - **힙(Heap)**은 우선순위 큐를 위해 고안된 완전이진트리 형태의 자료구조이다.
        - 여러 개의 값 중 최댓값 또는 최솟값을 찾아내는 연산이 빠르다.

### 예제

- 괄호
    - https://www.acmicpc.net/problem/9012
- 최소 힙
    - https://www.acmicpc.net/problem/1927
- 제로
    - https://www.acmicpc.net/problem/10773
- 카드 2
    - https://www.acmicpc.net/problem/2164
- 프린터큐 (어려움)
    - https://www.acmicpc.net/problem/1966
- 탑 (어려움)
    - https://www.acmicpc.net/problem/2493

---

### 출처

[https://ko.wikipedia.org/wiki/스택](https://ko.wikipedia.org/wiki/%EC%8A%A4%ED%83%9D)

[https://ko.wikipedia.org/wiki/큐_(자료_구조)](https://ko.wikipedia.org/wiki/%ED%81%90_(%EC%9E%90%EB%A3%8C_%EA%B5%AC%EC%A1%B0))

[https://velog.io/@ghdwp98/C-자료구조-힙Heap과-우선순위-큐Priority-Queue](https://velog.io/@ghdwp98/C-%EC%9E%90%EB%A3%8C%EA%B5%AC%EC%A1%B0-%ED%9E%99Heap%EA%B3%BC-%EC%9A%B0%EC%84%A0%EC%88%9C%EC%9C%84-%ED%81%90Priority-Queue)