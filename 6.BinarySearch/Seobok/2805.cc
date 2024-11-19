#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <vector>
#include <queue>
#include <math.h>
#include <algorithm>

using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(0);

	long long int N, M;

	int arr[1000001] = {};

	cin >> N >> M;

	long long int max = 0, mid = 0, min = 0;

	for (int i = 0; i < N; i++)
	{
		cin >> arr[i];
		if (i == 0)
		{
			max = arr[i];
		}
		if (max < arr[i])
			max = arr[i];
	}

	long long int ans = min;

	while (max>=min)
	{
		long long int sum = 0;
		mid = (max + min) / 2;
		for (int i = 0; i < N; i++)
		{
			if (arr[i] - mid > 0)
			{
				sum += arr[i] - mid;
			}
		}
		if (sum >= M)
		{
			if (ans < mid)
				ans = mid;
			min = mid + 1;
		}
		else if (sum < M)
		{
			max = mid - 1;
		}
	}

	cout << ans;

	return 0;
}