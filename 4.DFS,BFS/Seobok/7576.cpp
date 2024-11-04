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

	int M, N;

	cin >> M >> N;

	int** arr = new int* [N + 2];
	int** visited = new int* [N + 2];

	queue <pair<int, int>> store_tomato;

	for (int i = 0; i < N + 2; i++)
	{
		arr[i] = new int[M + 2];
		visited[i] = new int[M + 2];
	}

	for (int i = 0; i < N + 2; i++)
	{
		for (int j = 0; j < M + 2; j++)
		{
			if (i == 0 || i == N + 1 || j == 0 || j == M + 1)
			{
				arr[i][j] = -1;
			}
			else
			{
				int temp;
				cin >> temp;
				arr[i][j] = temp;
			}
			if (arr[i][j] == 1)
			{
				visited[i][j] = 1;
				store_tomato.push({ i,j });
				arr[i][j] = 0;
			}
			else if (arr[i][j] == -1)
				visited[i][j] = -1;
			else
				visited[i][j] = 0;
		}
	}

	int x[4] = { 0,0,-1,1 };
	int y[4] = { 1,-1,0,0 };	//╩С,го,аб,©Л

	while (!store_tomato.empty())
	{
		int loop = store_tomato.size();
		for (int i = 0; i < loop; i++)
		{
			int y_ = store_tomato.front().first;
			int x_ = store_tomato.front().second;
			for (int j = 0; j < 4; j++)
			{
				if (visited[y_ + y[j]][x_ + x[j]] == 0)
				{
					store_tomato.push({ y_ + y[j] ,x_ + x[j] });
					visited[y_ + y[j]][x_ + x[j]] = visited[y_][x_] + 1;
				}
			}
			store_tomato.pop();
		}
	}

	int max = -2;

	for (int i = 1; i < N + 1; i++)
	{
		for (int j = 1; j < M + 1; j++)
		{
			if (visited[i][j] > max)
			{
				max = visited[i][j];
			}
			if (visited[i][j] == 0)
			{
				max = -1;
				break;
			}
		}
		if (max == -1)
			break;
	}

	if (max == -1)
		cout << -1;
	else
		cout << max - 1;
}