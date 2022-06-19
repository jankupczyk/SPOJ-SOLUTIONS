#include <iostream>

using namespace std;

int tbl[10];
int amount;

void push()
{

    if (amount >= 10)
        cout << ":(" << endl;

    else
    {

        cin >> tbl[amount];
        amount = amount + 1;
        cout << ":)" << endl;
    }
}

void pop()
{
    if ( amount < 1 )
    {
        cout << tbl[amount - 1] << endl;
        amount = amount - 1;
    }
    else
    {
        cout << ":(" << endl;
    }
}

int main()
{

    int d;
    char a;

    while (cin >> a)
    {
        if (a == '+')
        {
            push();
        }
        else

            if (a == '-')
        {
            pop();
        }
    }

    return 0;
}