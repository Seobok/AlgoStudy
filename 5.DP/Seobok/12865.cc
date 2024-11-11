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

int arr[100001][101];

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(6);

	int N, K;
	cin >> N >> K;
	vector <pair<int,int>> v;
	for (int i = 0; i < N; i++)
	{
		int temp1, temp2;
		cin >> temp1 >> temp2;
		v.push_back({ temp1, temp2 });
	}

	sort(v.begin(), v.end());

	for (int i = 1; i <= N; i++)
	{
		for (int j = 1; j <= K; j++)
		{
			if (j >= v[i - 1].first)
				arr[j][i] = max(arr[j - v[i - 1].first][i - 1] + v[i - 1].second, arr[j][i - 1]);
			else
				arr[j][i] = arr[j][i - 1];
			
		}
	}

	cout << arr[K][N];
}