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

	/*cout << fixed;
	cout.precision(0);*/

	int arr[3];

	for (int i = 0; i < 3; i++)
	{
		cin >> arr[i];
	}

	sort(arr, arr + 3);

	for (int i = 0; i < 3; i++)
	{
		cout << arr[i] << " ";
	}
}