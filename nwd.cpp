#include <iostream>

int gcd(int a, int b) {
  if (b != 0)
    return gcd(b, a % b);

  return a;
}
int main() {
  int a, b;

  std::cin >> a;
  std::cin >> b;

  if ((a < 1 && a > 30000) || (b < 1 && b > 30000))
    return -1;

  std::cout << gcd(a, b) << std::endl;

  return 0;
}