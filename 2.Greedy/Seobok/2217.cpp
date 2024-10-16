#include <iostream>
#include <algorithm>

using namespace std;

int rope[100000];

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);

	int N = 0;
	cin >> N;

	for (int i = 0; i < N; i++)
	{
		cin >> rope[i];
	}

	sort(rope, rope + N);

	int max = -1;

	for (int i = 0; i < N; i++)
	{
		if (max < rope[i] * (N - i))
		{
			max = rope[i] * (N - i);
		}
	}

	cout << max;
}