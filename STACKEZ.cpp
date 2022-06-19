#include <bits/stdc++.h>
using namespace std;

int main(){
  int test; scanf("%d", &test);
  stack<int> sprawdz;
  while(test--){
      int x; scanf("%d", &x);
      if(x == 1){
          scanf("%d", &x);
          sprawdz.push(x);
      }
      else if(x == 2){
          if(!sprawdz.empty())
            sprawdz.pop();
      }
      else{
          if(sprawdz.empty()) printf("Empty!\n");
          else printf("%d\n", sprawdz.top());
      }
  }
  return 0;
}