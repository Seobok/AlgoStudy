# 이분탐색

- 결정문제의 답이 이분적일 때 사용할 수 있는 탐색 기법
    - F, F, F, F, …, F, T, T, …, T
- 경계를 포함하는 [lo,hi]를 잡은 뒤 구간의 길이를 절반씩 줄여나가며 lo,hi가 경계지점에 위치하도록 하는 것
- 이분탐색이 끝난 뒤 lo+1 == hi이며 Check(lo)≠Check(hi)

### 구현

- Check(lo)≠Check(hi)인 [lo,hi] 구간을 설정
- lo + 1 < hi인 동안 mid = lo+hi/2를 구해서
- Check(lo) == Check(mid)라면 lo = mid, Check(hi) == Check(mid)라면 hi = mid
- 정답이 가장 큰 F라면 lo, 가장 작은 T라면 hi

### 의사코드

```
binarySearch(A[0..N-1], value) { //k  
	low = 0
  high = N - 1
	while (low <= high) {
      mid = (low + high) / 2
			if (A[mid] > value)
          high = mid - 1
			else if (A[mid] < value)
          low = mid + 1
			else return mid // found k  
	}
	return -1 // not found k
}
```

![Binary_Search_Depiction](https://github.com/user-attachments/assets/cfecef49-11b2-40e0-8389-834259ea4aab)

### 예제

- 나무 자르기
    - https://www.acmicpc.net/problem/2805
- 예산
    - https://www.acmicpc.net/problem/2512

- 공유기 설치
    - https://www.acmicpc.net/problem/2110
- 가장 긴 증가하는 수열 2
    - https://www.acmicpc.net/problem/12015

---
### 참고

https://www.acmicpc.net/blog/view/109
