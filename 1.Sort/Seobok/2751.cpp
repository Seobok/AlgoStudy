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

	int* arr = new int[N];

	for (int i = 0; i < N; i++)
	{
		cin >> arr[i];
	}

	sort(arr, arr + N);

	for (int i = 0; i < N; i++)
	{
		cout << arr[i] << "\n";
	}

	return 0;
}