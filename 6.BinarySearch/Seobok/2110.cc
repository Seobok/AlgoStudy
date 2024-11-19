#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	int N, C;

	cin >> N >> C;

	int max = 0, min = 0;

	vector<int> house;

	for (int i = 0; i < N; i++)
	{
		int input;
		cin >> input;

		house.push_back(input);
	}

	sort(house.begin(), house.end());

	vector<int> dist;
	for (int i = 0; i < N - 1; i++)
	{
		int tempDist = house[i + 1] - house[i];
		dist.push_back(tempDist);
		max += tempDist;
	}

	if (C == 2)
	{
		cout << max;
		return 0;
	}

	while (max > min + 1)
	{
		int mid = (max + min) / 2;

		int cnt = 0;
		int sumDist = 0;

		for (int i : dist)
		{
			sumDist += i;
			if (sumDist >= mid)
			{
				cnt++;
				sumDist = 0;
			}
		}

		if (cnt < C - 1)
		{
			max = mid;
		}
		else
		{
			min = mid;
		}
	}

	cout << min;

	return 0;
}