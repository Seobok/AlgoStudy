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
	
	long long int arr[1001];
	long long int n;
	cin >> n;
	arr[1] = 1;
	arr[2] = 3;
	arr[3] = 5;

	for (int i = 4; i <= n; i++)
	{
		arr[i] = (arr[i - 1] % 10007 + arr[i - 2] % 10007 + arr[i - 2] % 10007) % 10007;
	}

	cout << arr[n];
}