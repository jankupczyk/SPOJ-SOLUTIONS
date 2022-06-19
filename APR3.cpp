#include <iostream>
using namespace std;

int main()
{
    int d = 0;

    int a, b;
    bool frst = false;

    cin >> d;

    while (d-- > 0)
    {
        cin >> a;
        cin >> b;
        frst = false;

        for (int i = 2; i <= a; i++)
        {
            if (b % i == 0 && a % i == 0)
            {
                frst = true;
                break;
            }
        }

        if (frst == true)
        {
            cout << "NIE" << endl;
        }
        else
        {
            cout << "TAK" << endl;
        }
    }
    return 0;
}