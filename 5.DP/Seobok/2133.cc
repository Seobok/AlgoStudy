#define _CRT_SECURE_NO_WARNINGS	
#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <vector>
#include <queue>
#include <stack>
#include <math.h>
#include <algorithm>
#include <map>
#include <set>
#include <tuple>

using namespace std;

int arr[31];

int dp(int N)
{
	if (N % 2 == 1)
		return 0;
	if (N == 0)
		return 1;
	if (N == 2)
		return 3;
	if (arr[N] != 0)
		return arr[N];

	int sum = 3 * dp(N - 2);
	for (int i = 0; i < N - 2; i++)
	{
		sum += dp(i) * 2;
	}

	return arr[N] = sum;
}

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(6);

	int N;
	cin >> N;

	cout << dp(N);
	
}