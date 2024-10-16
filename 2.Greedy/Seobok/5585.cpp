#define _CRT_SECURE_NO_WARNINGS	
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

	int N;
	cin >> N;
	int cnt = 0;

	N = 1000 - N;

	int arr[] = { 500, 100, 50, 10 ,5, 1 };

	for (int i = 0; i < 6; i++)
	{
		if (N >= arr[i])
		{
			cnt += N / arr[i];
			N = N % arr[i];
		}
	}

	cout << cnt;

}