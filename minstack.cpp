#include <bits/stdc++.h>
using namespace std;

int main()
{
    stack<pair<int, int> > take;
    int Q, aktualnie_mini = INT_MAX / 2;
    char qwerty[10];
    scanf("%d", &Q);
    while(Q--)
    {
        scanf("%s", qwerty);
        if(qwerty[0] == 'P' && qwerty[1] == 'U')
        {
            int val;
            scanf("%d", &val);
            int minimalna = val;
            if(take.size() > 0) minimalna = min(val, take.top().second);
            take.push(make_pair(val, minimalna));
        }
        else if(qwerty[0] == 'M')
        {
            if(take.size() == 0) puts("EMPTY");
            else printf("%d\n", take.top().second);
        }
        else
        {
            if(take.size() == 0) puts("EMPTY");
            else take.pop();
        }
    }
    return 0;
}