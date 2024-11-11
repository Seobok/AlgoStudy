#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;

int arr[1000];
int dp[1000];

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);

	int N;
	cin >> N;

	for (int i = 0; i < N; i++)
	{
		cin >> arr[i];
	}

	for (int i = 0; i < N; i++)
	{
		for (int j = i - 1; j >= 0; j--)
		{
			if (arr[i] > arr[j])
			{
				dp[i] = max(dp[i], dp[j] + 1);
			}
		}
	}

	int max = 0;

	for (int i = 0; i < N; i++)
	{
		if (max < dp[i])
			max = dp[i];
	}

	cout << max + 1;
}