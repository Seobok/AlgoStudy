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

	int N, M;
	int cnt = 0;
	int loc = 1;

	cin >> N >> M;

	stack<int>* graph = new stack<int>[N + 1];
	queue <int> q;
	int* visited = new int[N + 1];
	for (int i = 0; i < N + 1; i++)
	{
		visited[i] = 0;
	}

	for (int i = 0; i < M; i++)
	{
		int a, b;
		cin >> a >> b;
		graph[a].push(b);
		graph[b].push(a);
	}

	//ÀÔ·Âµð¹ö±ë
	/*for (int i = 1; i <= N; i++)
	{
		for (int j = 0; j < graph[i].size(); j++)
		{
			cout << graph[i][j] << " ";
		}
		cout << "\n";
	}*/

	while (1)
	{
		cnt++;
		visited[loc] = 1;
		int counter = graph[loc].size();
		for (int i = 0; i < counter; i++)
		{
			if (!visited[graph[loc].top()])
			{
				q.push(graph[loc].top());
				visited[graph[loc].top()] = 1;
			}
			graph[loc].pop();
		}
		if (q.empty())
			break;
		loc = q.front();
		q.pop();
	}

	cout << cnt - 1;

}