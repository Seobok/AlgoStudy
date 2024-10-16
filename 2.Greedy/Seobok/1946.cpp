#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int T;

	cin >> T;

	for (int tc = 0; tc < T; tc++)
	{
		int N;
		cin >> N;

		vector<pair<int, int>> people;

		for (int i = 0; i < N; i++)
		{
			int a, b;
			cin >> a >> b;

			people.push_back({ a, b });
		}

		sort(people.begin(), people.end());

		int limit = 100001;
		int res = 0;
		for (int i = 0; i < N; i++)
		{
			if (people[i].second < limit)
			{
				limit = people[i].second;
			}
			else
			{
				res++;
			}
		}

		cout << N - res << '\n';
	}
}