#include <iostream>

int silnia(int, int);

int main() {
    int t, n, k;
    std::cin >> t;
    for(int i = 0; i < t; i++) {
        std::cin >> n >> k;
        std::cout << silnia(n, k) << std::endl;
    }
    return 0;
}

int silnia(int a, int b) {
    if (a < b) {
        return 1;
    }
    return a * silnia(a - b, b);
}