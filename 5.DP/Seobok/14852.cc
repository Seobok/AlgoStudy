#include<iostream>
using namespace std;

long long int arr[1000001][2];

long long int dp(long long int N)
{
	arr[0][0] = 0;
	arr[1][0] = 2;
	arr[2][0] = 7;
	arr[2][1] = 1;

	for (int i = 3; i <= N; i++)
	{
		arr[i][1] = (arr[i - 3][0] + arr[i - 1][1]) % 1000000007;
		arr[i][0] = (arr[i - 1][0] * 2 + arr[i - 2][0] * 3 + arr[i][1] * 2) % 1000000007;
	}

	return arr[N][0];
}

int main()
{
	ios::sync_with_stdio(false);
	cin.tie(NULL);

	long long int N;
	cin >> N;

	cout << dp(N);
}