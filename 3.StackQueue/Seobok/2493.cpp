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

using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	/*cout << fixed;
	cout.precision(0);*/

	int N;
	cin >> N;

	int* arr = new int[N];
	int* ans = new int[N];
	for (int i = 0; i < N; i++)
	{
		cin >> arr[i];
		ans[i] = 0;
	}

	stack <pair<int, int>> s;	//first == ³ôÀÌ, second == index

	for (int i = N - 1; i >= 0; i--)
	{
		if (s.empty())
		{
			s.push({ arr[i], i });
		}
		else
		{
			while (!s.empty() && s.top().first <= arr[i])
			{
				ans[s.top().second] = i + 1;
				s.pop();
			}
			s.push({ arr[i], i });
		}
	}

	for (int i = 0; i < N; i++)
	{
		cout << ans[i] << " ";
	}
}