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

	int n;
	cin >> n;

	long long int* arr = new long long int[n + 1];

	arr[0] = 0;
	arr[1] = 1;

	for (int i = 2; i < n + 1; i++)
	{
		arr[i] = arr[i - 2] + arr[i - 1];
	}

	cout << arr[n];
}