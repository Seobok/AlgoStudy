#include <iostream>
#include <vector>
using namespace std;

int* lis;

int binarysearch(int left, int right, int target) {

	int mid;

	while (left < right) {
		mid = (left + right) / 2;

		if (lis[mid] < target) {
			left = mid + 1;
		}
		else {
			right = mid;
		}
	}
	return right;
}

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	int N;
	cin >> N;

	vector<int> v;
	for (int i = 0; i < N; i++)
	{
		int input;
		cin >> input;
		v.push_back(input);
	}

	lis = new int[N + 1];
	for (int i = 0; i <= N; i++)
	{
		lis[i] = 0;
	}

	int j = 0;
	lis[0] = v[0];
	int i = 1;

	while (i < N) {
		if (lis[j] < v[i]) {
			lis[j + 1] = v[i];
			j += 1;
		}
		else {
			int idx = binarysearch(0, j, v[i]);
			lis[idx] = v[i];
		}
		i += 1;
	}

	cout << j + 1;

	return 0;
}