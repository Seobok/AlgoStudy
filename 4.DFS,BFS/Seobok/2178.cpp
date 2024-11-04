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
	//cin.tie(NULL);
	//ios_base::sync_with_stdio(false);

	/*cout << fixed;
	cout.precision(0);*/

	int N, M;
	scanf("%d %d", &N, &M);
	int** arr = new int* [N + 2];
	int** dist = new int* [N + 2];
	for (int i = 0; i < N + 2; i++)
	{
		arr[i] = new int[M + 2];
		dist[i] = new int[M + 2];
	}

	for (int i = 0; i < N + 2; i++)
	{
		for (int j = 0; j < M + 2; j++)
		{
			if ((i == 0) || (i == N + 1) || (j == 0) || (j == M + 1))
			{
				arr[i][j] = 0;
			}
			else
				scanf("%1d", &arr[i][j]);
			dist[i][j] = 0;
		}
	}

	bool find = false;
	queue<pair<int, int>> q;
	q.push({ 1,1 });
	dist[1][1] = 1;
	int x[4] = { -1, 1, 0, 0 };
	int y[4] = { 0, 0, -1, 1 };	//K=0=>left, K=1=>right, K=2=>down, K=3=>up
	arr[q.front().first][q.front().second] = 0;

	while (1)
	{
		for (int i = 0; i < 4; i++)
		{
			if (arr[q.front().first + y[i]][q.front().second + x[i]] == 1)
			{
				if (q.front().first + y[i] == N && q.front().second + x[i] == M)
				{
					dist[q.front().first + y[i]][q.front().second + x[i]] = dist[q.front().first][q.front().second] + 1;
					find = true;
					break;
				}
				else
				{
					q.push({ q.front().first + y[i], q.front().second + x[i] });
					arr[q.front().first + y[i]][q.front().second + x[i]] = 0;
					dist[q.front().first + y[i]][q.front().second + x[i]] = dist[q.front().first][q.front().second] + 1;
				}
			}
		}
		if (find)
			break;
		q.pop();
	}

	printf("%d", dist[N][M]);

}