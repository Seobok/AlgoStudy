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

	int T, N, M;

	cin >> T;

	for (int t = 0; t < T; t++)
	{
		cin >> N >> M;	//문서갯수, 중요도

		queue<pair<int, int>> q;	//인덱스,중요도
		vector<int> imp;

		for (int i = 0; i < N; i++)
		{
			int temp;	//중요도
			cin >> temp;
			q.push(make_pair(i, temp));
			imp.push_back(temp);
		}

		sort(imp.begin(), imp.end());

		int ans = 1;

		while (true)
		{
			if (imp.back() == q.front().second)
			{
				if (q.front().first == M)
				{
					break;
				}
				else
				{
					q.pop();
					imp.pop_back();
					ans++;
				}
			}
			else
			{
				int q1 = q.front().first, q2 = q.front().second;

				q.pop();
				q.push(make_pair(q1, q2));
			}
		}

		cout << ans << "\n";
	}

	return 0;
}