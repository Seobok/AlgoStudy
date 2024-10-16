#define _USE_MATH_DEFINES

#include <iostream>
#include <string>
#include <vector>
#include <math.h>
#include <algorithm>

using namespace std;

int main()
{
	cin.tie(NULL);
	ios_base::sync_with_stdio(false);

	//cout << fixed;
	//cout.precision(6);

	int N;

	cin >> N;

	int arr[10001] = {};

	for (int i = 0; i < N; i++)
	{
		int a;
		cin >> a;
		arr[a]++;
	}

	for (int i = 0; i < 10001; i++)
	{
		for (int j = 0; j < arr[i]; j++)
		{
			cout << i << "\n";
		}
	}

	return 0;
}