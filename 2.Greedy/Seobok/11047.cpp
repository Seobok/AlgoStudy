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

	int N, K;
	cin >> N >> K;
	stack <int> v;
	int cnt = 0;
	for (int i = 0; i < N; i++)
	{
		int temp;
		cin >> temp;
		v.push(temp);
	}

	while (K > 0)
	{
		if (!v.empty())
		{
			if (v.top() <= K)
			{
				K -= v.top();
				cnt++;
			}
			else
			{
				v.pop();
			}
		}
	}

	cout << cnt;
}